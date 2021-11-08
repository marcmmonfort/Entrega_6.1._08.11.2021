#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <mysql.h>

int main (int argc, char **argv)  {
	
	MYSQL *conn;
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	char consulta [120];
	conn=mysql_init(NULL);
	
	if (conn ==NULL){
		printf ("Error al crear la conexion: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	//inicializar la conexion, indicando nuestras claves de acceso
	// al servidor de bases de datos (user,pass)
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "Diez", 0, NULL, 0);
	if (conn==NULL)
	{
		printf ("Error al inicializar la conexion: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	strcpy (consulta, "SELECT distinct(Participacion.sumaCreditos) FROM(Partida, Participacion, Jugador) WHERE Partida.ganador = 'Marc' AND Partida.fecha = '10/10/2021' AND Partida.IDPartida = Participacion.IDP AND Jugador.IDJugador = Participacion.IDJ;");
	
	err=mysql_query (conn, consulta);
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	resultado = mysql_store_result (conn);
	
	row = mysql_fetch_row (resultado);
	if (row == NULL)
		printf ("No se han obtenido datos en la consulta\n");
	else
		while (row !=NULL) {
			
			printf ("\nSuma de créditos: %s", row[0]);
			// obtenemos la siguiente fila
			row = mysql_fetch_row (resultado);
	}
		// cerrar la conexion con el servidor MYSQL 
		mysql_close (conn);
		
		printf ("\nOK");
		return(0);
}