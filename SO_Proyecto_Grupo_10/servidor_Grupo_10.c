// - - - - - - - - - - - LIBRARY - - - - - - - - - - -

#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <ctype.h>
#include <mysql.h>

// - - - - - - - - - - - FUNCTIONS - - - - - - - - - - -

// #1. CONSULTA EL NÚMERO DE PARTIDAS DE UN JUGADOR. - - - - -

int NumPartidas(char nombre[50]) {
	
	int partidas;
	
	MYSQL *conn;
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	conn = mysql_init(NULL);
	
	if (conn==NULL) {
		partidas = -1;
		exit (1);
	}
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "Diez",0, NULL, 0);
	if (conn==NULL) {
		partidas = -1;
		exit (1);
	}
	
	char mensaje[1000];
	strcpy(mensaje, "SELECT count(*) FROM (Jugador, Participacion) WHERE (Jugador.usuario = '");
	strcat(mensaje, nombre);
	strcat(mensaje, "') AND (Participacion.IDJ = Jugador.IDJugador);");
	
	err = mysql_query (conn, mensaje);
	if (err!=0) {
		partidas = -1;
		exit (1);
	}
	
	resultado = mysql_store_result (conn);
	row = mysql_fetch_row (resultado);
	
	if (row == NULL)
		partidas = -1;
	else {
		partidas = atoi(row[0]);
	}
	
	mysql_close(conn);
	// exit(0);
	
	return partidas;
}

// #2. CONSULTA EL NÚMERO DE CRÉDITOS DEL GANADOR DE UNA PARTIDA EN UNA FECHA CONCRETA. - - - - -

int SumaCreditos(char ganador[50], char fecha[50]) {
	
	int sumCreditos;
	
	MYSQL *conn;
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	conn = mysql_init(NULL);
	
	if (conn==NULL) {
		sumCreditos = -1;
		exit (1);
	}
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "Diez",0, NULL, 0);
	if (conn==NULL) {
		sumCreditos = -1;
		exit (1);
	}
	
	
	char mensaje[1000];
	strcpy(mensaje, "SELECT Participacion.sumaCreditos FROM (Partida, Participacion, Jugador) WHERE Partida.ganador = '");
	strcat(mensaje, ganador);
	strcat(mensaje, "' AND Jugador.usuario = '");
	strcat(mensaje, ganador);
	strcat(mensaje, "' AND Partida.fecha = '");
	strcat(mensaje, fecha);
	strcat(mensaje, "' AND (Partida.IDPartida = Participacion.IDP) AND (Jugador.IDJugador = Participacion.IDJ);");
	err = mysql_query (conn, mensaje);
	if (err!=0) {
		sumCreditos = -1;
		exit (1);
	}
	
	resultado = mysql_store_result (conn);
	row = mysql_fetch_row (resultado);
	
	if (row == NULL)
		sumCreditos = -1;
	else {
		sumCreditos = atoi(row[0]);
	}
	
	mysql_close(conn);
	// exit(0);
	
	return sumCreditos;
}

// #3. ELOI. - - - - -

int GanadorContra(char nombre[50], char * perdedores){
	
	MYSQL *conn;
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	conn = mysql_init(NULL);
	
	
	
	if (conn==NULL) {
		exit (1);
	}
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "Diez",0, NULL, 0);
	if (conn==NULL) {
		exit (1);
	}
	
	char mensaje[1000];
		
	strcpy(mensaje, "SELECT IDJugador FROM Jugador WHERE usuario = '");
	strcat(mensaje, nombre);
	strcat(mensaje, "';");
	
	err = mysql_query (conn, mensaje);
	if (err!=0) {
		exit(1);
	}
	
	resultado = mysql_store_result (conn);
	row = mysql_fetch_row (resultado);
	
	strcpy(mensaje, "SELECT distinct(usuario) from (Jugador,Participacion,Partida) where Jugador.IDJugador = Participacion.IDJ and Partida.IDPartida = Participacion.IDP and Partida.ganador='");
	strcat(mensaje, nombre);
	strcat(mensaje, "'and Participacion.IDJ<>");
	strcat(mensaje, row[0]);
	strcat(mensaje, ";");
	
	err = mysql_query (conn, mensaje);
	if (!err) {
		
		resultado = mysql_store_result (conn);
		row = mysql_fetch_row (resultado);
		strcpy (perdedores, "\0");
	
		while (row != NULL){
			strcat (perdedores, "\n");
			strcat (perdedores, row[0]);
			row = mysql_fetch_row(resultado);
			
		}
	}		
	
	mysql_close(conn);
	return 0;
	
}

// #4. LOGIN. - - - - -

// Si existe el usuario, y la contraseña es la correcta, entonces devuelve 0.
// Si no, devuelve -1.

int CheckPassword(char nombre[50], char contra[50]) 
{
	MYSQL *conn;
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	conn = mysql_init(NULL);
	if (conn==NULL) {
		printf ("Error al crear la conexion: %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "Diez",0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	char mensaje[1000];
	strcpy(mensaje, "SELECT Jugador.contraseña FROM (Jugador) WHERE (Jugador.usuario = '");
	strcat(mensaje, nombre);
	strcat(mensaje, "');");
	
	err = mysql_query (conn, mensaje);
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	resultado = mysql_store_result (conn);
	row = mysql_fetch_row (resultado);
	
	char contraVerdadera[50];
	
	if (row == NULL)
		printf ("No se han obtenido datos en la consulta\n");
	else {
		strcpy(contraVerdadera,row[0]);
	}
	
	mysql_close(conn);
	// exit(0);
		
	if (strcmp(contraVerdadera, contra) == 0)
	{
		return 0;
	}
	else
	{
		return -1;
	}
}

// #5. REGISTER. - - - - -
int Register(char nombre[50], char contra[50]) 
{
	MYSQL *conn;
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	conn = mysql_init(NULL);
	if (conn==NULL) {
		printf ("Error al crear la conexion: %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "Diez",0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	char mensaje[1000];
	strcpy(mensaje, "INSERT INTO Jugador(contraseña) VALUES ('" );
	strcat(mensaje, contra);
	strcat(mensaje, "');");
	strcpy(mensaje, "INSERT INTO Jugador(usuario) VALUES ('" );
	strcat(mensaje, nombre);
	strcat(mensaje, "');");
	
	err = mysql_query (conn, mensaje);
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	resultado = mysql_store_result (conn);
	row = mysql_fetch_row (resultado);
	
	char contraVerdadera[50];
	
	if (row == NULL)
		printf ("No se han obtenido datos en la consulta\n");
	else {
		strcpy(contraVerdadera,row[0]);
	}
	
	mysql_close(conn);
	// exit(0);
}


// - - - - - - - - - - - MAIN - - - - - - - - - - -

int main(int argc, char *argv[])
{
	
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	
	memset(&serv_adr, 0, sizeof(serv_adr));
	serv_adr.sin_family = AF_INET;
	
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	serv_adr.sin_port = htons(9015);
	
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	
	if (listen(sock_listen, 3) < 0)
		printf("Error en el Listen");
	
	int i;
	for (;;){ // Bucle infinito (siempre escucha).
		printf ("Escuchando\n");
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		int terminar = 0;
		while (terminar == 0)
		{
			
			ret=read(sock_conn,peticion, sizeof(peticion));
			printf ("Recibido\n");
			peticion[ret]='\0';	
			printf ("Peticion: %s\n",peticion);
			
			char *p = strtok( peticion, "/");
			int codigo =  atoi (p); // Número de petición.
			
			if (codigo == 0)
				terminar = 1;
			
			else if (codigo ==1) // PETICIÓN DE ALBA.
			{
				// Ponemos en 'ganador' el nombre del usuario que pregunta.	
				char ganador[50];
				p = strtok( NULL, "/");
				strcpy (ganador, p);				
				//Ponemos en 'fecha' la fecha de la partida.	
				char fecha[50];
				p = strtok(NULL, " ");
				strcpy (fecha, p);
				int sumCreditos = SumaCreditos(ganador, fecha);
				
				char answer[20];
				sprintf(answer, "%d", sumCreditos);
				strcpy (respuesta,answer); // Devuelve el número de créditos como respuesta.
			}
			
			else if (codigo ==2) // PETICIÓN DE MARC.
			{
				// Ponemos en 'nombre' el nombre del usuario que pregunta.				
				char nombre[50];
				p = strtok( NULL, "/");
				strcpy (nombre, p);
				
				int partidas = NumPartidas(nombre);
				
				char answer[20];
				sprintf(answer, "%d", partidas);
				strcpy (respuesta,answer); // Devuelve el número de partidas como respuesta.
			}
			
			else if (codigo ==3) // PETICIÓN DE ELOI.
			{
				char nombre[50];
				p = strtok( NULL, "/");
				strcpy (nombre, p);
				
				char perdedores [512];
				strcpy (perdedores, "\0");
				int ret = GanadorContra(nombre, perdedores);
				strcpy (respuesta,perdedores); // Devuelve la lista de jugadores que han perdido contra el usuario seleccionado.
			}
			
			else if (codigo ==4) // PETICIÓN LOGIN.
			{
				// Ponemos en 'nombre' el nombre del usuario que pregunta.				
				char nombre[50];
				p = strtok( NULL, "/");
				strcpy (nombre, p);
				
				char contra[50];
				p = strtok( NULL, "/");
				strcpy (contra, p);
				
				int verificar = CheckPassword(nombre,contra);
				
				char answer[20];
				sprintf(answer, "%d", verificar);
				strcpy (respuesta,answer);
			}
			
			else if (codigo ==5) // PETICIÓN REGISTER.
			{
				// Ponemos en 'nombre' el nombre del usuario que pregunta.				
				char nombre[50];
				p = strtok( NULL, "/");
				strcpy (nombre, p);
				
				char contra[50];
				p = strtok( NULL, "/");
				strcpy (contra, p);
				
				int registrar = Register(nombre,contra);
				
				char answer[20];
				sprintf(answer, "%d", registrar);
				strcpy (respuesta,answer);
			}
			
			if (codigo != 0)
			{
				printf ("Respuesta: %s\n", respuesta);
				write (sock_conn,respuesta, strlen(respuesta));
			}
		}
		close(sock_conn); 
	}
}
