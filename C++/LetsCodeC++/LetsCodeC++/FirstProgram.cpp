#include<iostream>
using namespace std;

int main() {
	
	int a = 110;			cout << "int = ";
	cout << a << endl;

	char b = 'S';			cout << "char = ";
	cout << b << endl;

	bool bl = true;			cout << "bool = ";
	cout << bl << endl;

	float f = 3.13;			cout << "float = ";
	cout << f << endl;

	double d = 14.110;		cout << "double = ";
	cout << d << endl;


	//check the size of datatype in a memory
	int Size = sizeof(d);
	cout << "Size of d`	 is = " << Size << endl;
}