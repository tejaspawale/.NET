#include <iostream>

using namespace std;

int Sum(int x, int y)
{
	cout << x + y << endl;

	return x + y;
}

int main()
{
	// One of my favorite features of C++11 ;)

	auto i = 24;
	auto j = 5;

	auto sum = i + 4.3f;

	auto result = Sum(i, j);

	static auto y = 2;

	const int x = 10;

	// Works with qualifiers
	const auto var = x;

	// Deduced to reference
	const auto &var1 = x;

	// Deduced to pointer
	auto *ptr = &x;

	return 0;
}