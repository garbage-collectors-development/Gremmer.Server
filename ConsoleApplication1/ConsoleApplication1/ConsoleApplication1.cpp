#include<iostream>
#include<iomanip>

using namespace std;

int main()
{
	int a, b, c;

	c = false;

	int x, y, z;

	x = 0;

	z = 1;

	int g, h;

	int i, j;

	int k, l;

	i = 0;

	j = 0;

	const int arraysize1 = 20;

	const int arraysize2 = 20;

	int floor[arraysize1][arraysize2];

	for (int m = 0; m < arraysize1; m++)
	{
		for (int n = 0; n < arraysize2; n++)
		{
			floor[m][n] = false;

		}

	}

	cout << " press '1' for pen up | press '2' for pen down | press '3' to turn right | press '4' to turn left | press '5' and 'n' to move forward n step ";

	cout << " press '6' to print 20 by 20 array | press '9' for End Of Data (sentinel) : \n";

	cin >> a;

	while (a != 9)
	{
		if (a == 5)
		{
			cin >> b;

		}

		if (a == 1)
		{
			c = false;

		}

		if (a == 2)
		{
			c = true;

		}

		if (a == 3)
		{
			x++;

		}

		if (a == 4)
		{
			x++;

			z = z * (-1);

		}

		y = x % 4;

		switch (y)
		{
		case 0:
			g = 1 * z;
			h = 0;
			break;

		case 1:
			g = 0;
			h = 1 * z;
			break;

		case 2:
			g = (-1) * z;
			h = 0;
			break;

		case 3:
			g = 0;
			h = (-1) * z;
			break;
		}

		for (int d = 0; d < b; d++)
		{
			k = i + d * h;

			l = j + d * g;

			if (c == true)
				floor[k][l] = true;

		}

		i = k;

		j = l;

		if (a == 6)
		{
			for (int i = 0; i < arraysize1; i++)
			{
				for (int j = 0; j < arraysize2; j++)
				{
					if (floor[i][j] == true)
					{
						cout << " *";

					}

					if (floor[i][j] == false)
					{
						cout << "  ";

					}

				}

				cout << endl;
			}
		}

		cin >> a;

	}

	return 0;

}