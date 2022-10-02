#include<stdio.h>

main(){

int a,b,*pa,*pb;

a=1;
b=2;
pa=&a;
a=*pa+3;
a=a+((*(&a))*3);
b=a;
pb=&b;
b=(*pa)+(*pb);

printf(" a= %d \n",a);
printf(" b= %d \n",b);
printf(" pa= %d \n",pa);
printf(" pb= %d \n",pb);
printf(" &a= %d \n",&a);
printf(" &b= %d \n",&b);
printf(" *pa= %d \n",*pa);
printf(" *pb= %d \n",*pb);





}
