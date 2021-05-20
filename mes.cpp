#include <stdio.h>
#include <stdlib.h>

int main(void){
	
	int mes;
	char buffer[256];
	
	
	printf("insira o valor de meses para saber o total de dias: ");
	
	
	fgets(buffer, 256, stdin);
	
	while(sscanf(buffer, "%d", &mes) != 1){
		printf("Insira somente numeros!\n");
		printf("insira o numero para receber o dobro dele: ");
		fgets(buffer, 256, stdin);
	}
	
	while(mes < 1 || mes > 12){
		printf("Mes nao existe, somente de 1 a 12: ");
		fgets(buffer, 256, stdin);
			while(sscanf(buffer, "%d", &mes) != 1){
			printf("Insira somente numeros!\n");
			printf("insira o numero para receber o dobro dele: ");
			fgets(buffer, 256, stdin);
		}
	}


	printf("\n\nRsultado: %d\n\n", mes*30);
	
	
	system ("pause");
	
	return 0; 
}
