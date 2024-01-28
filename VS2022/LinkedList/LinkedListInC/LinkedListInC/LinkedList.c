	/* Program to illustrate traversing a list */
	#include <stdio.h>
	struct node {
		int         data;
		struct node *next;
	};

	int num;

	main()
	{
		struct node n1, n2, n3, n4;
		struct node *listp = &n1;

		n1.data = 100;
		n1.next = &n2;
		n2.data = 200;
		n2.next = &n3;
		n3.data = 300;
		n3.next = &n4;
		n4.data = 400;
		n4.next = 0;


		while( listp != 0 )  {
			printf("%d\n", listp->data);
			listp = listp->next;
		}

		scanf_s("%d", &num);
}
	

