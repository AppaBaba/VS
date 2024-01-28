#include<stdlib.h>
#include<stdio.h>

struct node {
   int data;
   struct node * next;
};

typedef struct node item;

void main() {
   item * curr, * head;
   int i;  
   int num;
   head = NULL;

   for(i=1;i<=10;i++) {
      curr = (item *)malloc(sizeof(item));
      curr->data = i;
      curr->next  = head;
      head = curr;
   }

   curr = head;

   while(curr) {
      printf("%d\n", curr->data);
      curr = curr->next ;
   }
   
   scanf_s("%d", &num);
}

