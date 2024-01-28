#include<stdlib.h>
#include<stdio.h>

struct node {
   int data;
   struct node * next;
};

typedef struct node item;

void main() {
   item * head, * body, * tail;
     
   int num;

   head = NULL;
   body = NULL;
   tail = NULL;

   head = (item *)malloc(sizeof(item));                // allocate 3 nodes on the heap
   body = (item *)malloc(sizeof(item));
   tail = (item *)malloc(sizeof(item));
      
   head->data = 1;                                     // setup first node
   head->next  = body;

   body->data = 2;                                     // setup second node
   body->next = tail;

   tail->data = 3;                                     // setup third node
   tail->next = NULL;
   
   printf("%d\n", head->data);
   printf("%d\n", body->data);
   printf("%d\n", tail->data);
   
   
   scanf_s("%d", &num);
}

