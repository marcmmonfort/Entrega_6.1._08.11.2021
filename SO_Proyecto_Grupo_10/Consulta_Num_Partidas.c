#include <string.h>
#include <stdlib.h>
#include <stdio.h>
#include <mysql.h>

int main(int argc, char **argv)
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
	
	char nombre[100];
	printf("Número de partidas jugadas por ... ");
	scanf("%s", nombre);
	char mensaje[1000];
	strcpy(mensaje, "SELECT count(*) FROM (Jugador, Participacion) WHERE (Jugador.usuario = '");
	strcat(mensaje, nombre);
	strcat(mensaje, "') AND (Participacion.IDJ = Jugador.IDJugador);");

	err = mysql_query (conn, mensaje);
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	resultado = mysql_store_result (conn);
	row = mysql_fetch_row (resultado);
	
	if (row == NULL)
		printf ("No se han obtenido datos en la consulta\n");
	else {
			printf ("%s ha jugado %s partidas.\n", nombre, row[0]);
		}
	
	mysql_close(conn);
	exit(0);
}
