#include <stdio.h>/*אחמד סכרן 318308186*/
int main()

{
	char x, b;
	printf("helo ther, this app give you the absolute value of the subtract between the value of two chares in ascii table ");
	printf("so now please enter 2 char ");
	scanf_s("%c\n",&x);
	scanf_s("%c", &b);
	if (x - b < 0)
	{
		printf("the difference between the values is %d", (x - b)*-1);
		return 0;
	}
	printf("the difference between the values is %d", (x - b));
	return 0;
}
/*helo ther, this app give you the absolute value of the subtract between the value of two chares in ascii table so now please enter 2 char a
m
the difference between the values is 12
C:\Users\lenovo\source\repos\Project3\Debug\Project3.exe (process 480) exited with code 0.
To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
Press any key to close this window . . .
*/