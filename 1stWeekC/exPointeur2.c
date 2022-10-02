#include<stdio.h>

main(){
int a,b,c,*p1,*p2;
a=1;
b=2;
c=3;

p1=&a;
p2=&c;
*p1=(*p2)++;

p1=p2;
p2=&b;
*p1-=*p2;

printf("p1=%d \n",p1);
printf("p2=%d \n",p2);
printf("*p1=%d \n",*p1);
printf("*p2=%d \n",*p2);
//printf(" c=%d \n",c);







}
