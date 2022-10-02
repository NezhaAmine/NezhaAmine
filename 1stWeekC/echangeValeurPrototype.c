#include<stdio.h>
void echange(float*,float*);
main(){
float a,b;
printf("saisir la premiere valeur  :\n");
scanf("%f", &a);
printf("saisir la deuxieme valeur  :\n");
scanf("%f", &b);

printf("valeurs avant echange : a = %f et b=%f\n ",a,b);

echange(&a,&b);
printf("valeurs apres echange : a = %f et b=%f\n ",a,b);



}

void echange (float  *k,float *f){

float c;

c=*k;
*k=*f;
*f=c;



}
