#include <iostream>
using namespace std;

class Node{
    public:
    	int data;
	Node * next;
	Node(int x){
		data = x;
		next = NULL;
		}
	Node(int x, Node * y){
		data = x; 
		next = y;
		}
    };


class linkedList{
Node *head;
public:
	linkedList(){
		head = NULL;
		}
	void addNode(int value){
		Node *p;
		if(head == NULL)
			head = new Node (value, NULL);
		else{
			p=head;
			while(p->next !=NULL)
				p=p->next;
			p->next = new Node (value, NULL);
			}
		}
	void print(){
		Node * p;
		p = head;
		while(p != NULL){
			cout << p->data << "\n";
			p = p->next;
			}
		}
};


int main(void){
	char c;
    linkedList list;
    list.addNode(8);
    list.addNode(26);
    list.addNode(14);
    list.print();


cin >> c;

return(0);
}