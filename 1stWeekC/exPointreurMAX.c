#include <stdio.h>

int max(int *, int*);
float moy(int *, int*);
int fact(int *, int*);
main(){

int a,b;
 printf("saisir le premier entier: ");
 scanf("%d",&a);

 printf("saisir le deuxieme entier: ");
 scanf("%d",&b);


printf("le max est : %d \n", max(&a,&b));
printf("la moy est : %f \n", moy(&a,&b));
printf("le factoriel est : %d \n", fact(&a,&b));



}

int max(int *x, int*y){
int maximum;
if(*x>*y){

    maximum=*x;

}
else if(*x!=*y){
maximum=*y;


}

return maximum;



}


float moy(int *x,int *y){


float moyenne,som;
som= *x+*y;
moyenne= som/2;
return moyenne;


}

fact (int *x,int*y){


int i,max,f;
f=1;
if(*x>*y){

    max=*x;


}else if(*x!=*y){
max=*y;
}

for(i=1;i<=max;i++){

  f=f*i;


}
return f;
}
