// text.cpp : �������̨Ӧ�ó������ڵ㡣
//

#include "stdafx.h"
#include <iostream>
#include <math.h>
#include <time.h>

using namespace std;
float* getvalues(float r,float h){//���㷽��
	float p =3.14;
	float *a;
	a=new float[5];
	float L,S1,S2,V1,V2,r2,r3;
	L=2*p*r;
	r2=pow(r,2);
	S1=p*r2;
	S2=4*p*r2;
	r3=pow(r,3);
	V1=4/3*p*r3;
	V2=S1*h;
	a[0]=L;a[1]=S1;a[2]=S2;a[3]=V1;a[4]=V2;
	return a;
}
int main()
{
	/*
	double p =pow(1.07,10);
	printf("\t\t\t\tp is: %d\n",p);
	int a,b,d;
	char c;
	printf("\t\t\t\t������һ���������\n");
	scanf("\t\t\t\t%c",&c);
	printf("\t\t\t\t��������������\n");
	scanf("\t\t\t\t%d",&a);
	scanf("\t\t\t\t%d",&b);
	switch(c)
	{
	case '+':
	d=a+b;break;
	case '-':
	d=a-b;break;
	case '*':
	d=a*b;break;
	case '/':
	d=a/b;break;
	default: break;
	}
 
	 printf("\t\t\t\t%d",d);
	 float a,b,C;
	 printf("\t\t\t\t����ֵ��ʽΪr=ֵ,h=ֵ:\n");
	 scanf("\t\t\t\ta=%f,b=%f",&a,&b);
	 C=2*3.14*a;
	 printf("\t\t\t\t�ܳ�c=%.2f",C);
	
	*/
	
	/*
	char c;
	printf("\t\t\t\t�Ƿ���Ҫ�������ֵ��\n");
	scanf("\t\t\t\t%c",&c);
	if(c=='y'){//�������y����Ҫ����ֵ
		float r,h;
		printf("\t\t\t\t����ֵ��ʽΪr=ֵ,h=ֵ:\n");
		getchar();
		scanf("\t\t\t\tr=%f,h=%f",&r,&h);
		float* value= getvalues(r,h);
		printf("\t\t\t\tԲ�ܳ�Ϊ:%.2f\nԲ���Ϊ:%.2f\nԲ������Ϊ:%.2f\nԲ�����Ϊ:%.2f\nԲ�����Ϊ:%.2f",value[0],value[1],value[2],value[3],value[4]);
	}
	else if(c=='n'){//��������nֱ����д�õ�ֵ���м���
		float* value= getvalues(1.5,3);
		printf("\t\t\t\tԲ�ܳ�Ϊ:%.2f\nԲ���Ϊ:%.2f\nԲ������Ϊ:%.2f\nԲ�����Ϊ:%.2f\nԲ�����Ϊ:%.2f",value[0],value[1],value[2],value[3],value[4]);
	}else{//ֱ�ӻس��������
		printf("\t\t\t\t�ѽ���");
	}
	return 0;
	*/
	int a=0;
	double start,finish;
	double totaltime;
	start=clock();
	for(int i=0;i<1000000;i++){
		printf("\t\t\t\t                                             *                                                                       \n");
		printf("\t\t\t\t                                            ***                                                                      \n");
		printf("\t\t\t\t                                           *   *                                                                     \n");
		printf("\t\t\t\t                                          *     *                                                                    \n");
		printf("\t\t\t\t                                         *       *                                                                   \n");
		printf("\t\t\t\t                                        *    *    *                                                                  \n");
		printf("\t\t\t\t                                       *     *     *                                                                 \n");
		printf("\t\t\t\t                                       *     *     *                                                                 \n");
		printf("\t\t\t\t                                        *    *    *                                                                  \n");
		printf("\t\t\t\t                                         *       *                                                                   \n");
		printf("\t\t\t\t                                          *     *                                                                    \n");
		printf("\t\t\t\t                                           *   *                                                                     \n");
		printf("\t\t\t\t                                            ***                                                                      \n");
		printf("\t\t\t\t                                             *                                                                       \n");
		printf("\t\t\t\t                               *****************************                                                         \n");
		printf("\t\t\t\t                                ***************************                                                          \n");
		printf("\t\t\t\t                                 *************************                                                           \n");
		printf("\t\t\t\t                                  ***********************                                                            \n");
		printf("\t\t\t\t                                   *********************                                                             \n");
		printf("\t\t\t\t                                    *******************                                                              \n");
		printf("\t\t\t\t                                     **             **                                                               \n");
		printf("\t\t\t\t                                    *******************                                                              \n");
		printf("\t\t\t\t                                   *********************                                                             \n");
		printf("\t\t\t\t                                  ***********************                                                            \n");
		printf("\t\t\t\t                                 *************************                                                           \n");
		printf("\t\t\t\t                                ***************************                                                          \n");
		printf("\t\t\t\t              **             ********************************             **                                         \n");
		printf("\t\t\t\t               **         ***********                 **********          **                                          \n");
		printf("\t\t\t\t                *********************                 *******************                                            \n");
		printf("\t\t\t\t                *********************                 *******************                                            \n");
		printf("\t\t\t\t                *********************                 *******************                                            \n");
		printf("\t\t\t\t               **         ***********                 *********          **                                          \n");
		printf("\t\t\t\t              **             ********************************             **                                         \n");
		printf("\t\t\t\t                               *****************************                                                         \n");
		printf("\t\t\t\t                                ***************************                                                          \n");
		printf("\t\t\t\t                                 *************************                                                           \n");
		printf("\t\t\t\t                                  ***********************                                                            \n");
		printf("\t\t\t\t                                   *********************                                                             \n");
		printf("\t\t\t\t                                    *******************                                                              \n");
		printf("\t\t\t\t                                     **             **                                                               \n");
		printf("\t\t\t\t                                    *******************                                                              \n");
		printf("\t\t\t\t                                   *********************                                                             \n");
		printf("\t\t\t\t                                  ***********************                                                            \n");
		printf("\t\t\t\t                                 *************************                                                           \n");
		printf("\t\t\t\t                                ***************************                                                          \n");
		printf("\t\t\t\t                                             *                                                                       \n");
		printf("\t\t\t\t                                            ***                                                                      \n");
		printf("\t\t\t\t                                           *   *                                                                     \n");
		printf("\t\t\t\t                                          *     *                                                                    \n");
		printf("\t\t\t\t                                         *       *                                                                   \n");
		printf("\t\t\t\t                                        *    *    *                                                                  \n");
		printf("\t\t\t\t                                       *     *     *                                                                 \n");
		printf("\t\t\t\t                                       *     *     *                                                                 \n");
		printf("\t\t\t\t                                        *    *    *                                                                  \n");
		printf("\t\t\t\t                                         *       *                                                                   \n");
		printf("\t\t\t\t                                          *     *                                                                    \n");
		printf("\t\t\t\t                                           *   *                                                                     \n");
		printf("\t\t\t\t                                            ***                                                                      \n");
		printf("\t\t\t\t                                             *                                                                       \n");
		printf("\t\t\t\t\n\n\n\n\n");
		//printf("\t\t\t\tfor i is:%d\n",i);
		if(i==999999){
			i=0;
			a++;
			//printf("\t\t\t\tfor a is:%d\n",a);
		}
		if(a==10000000000){
			break;
		}
	}
	finish=clock();
	totaltime=(finish-start)/CLOCKS_PER_SEC;
	printf("\t\t\t\ttimes is :%f",totaltime);
	printf("\t\t\t\ttimes is :%f",totaltime);
}


