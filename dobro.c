#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#include <conio.h>

int main(void){
	
	float num;
	char buffer[256];
	
	
	printf("insira o numero para receber o dobro dele: ");
	
	
	fgets(buffer, 256, stdin);
	
	while(sscanf(buffer, "%f", &num) != 1){
		printf("Insira somente numeros!\n");
		printf("insira o numero para receber o dobro dele: ");
		fgets(buffer, 256, stdin);
	}


	printf("\n\nRsultado: %.2f\n\n", num*num);
	
	
	system ("pause");
	
	return 0; 
}
