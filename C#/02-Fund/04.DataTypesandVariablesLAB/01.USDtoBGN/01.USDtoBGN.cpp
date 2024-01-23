// 01.USDtoBGN.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

int main()
{
    
    double usd, bgn;
    cin >> usd;
    bgn = usd * 1.79549;
    printf("${bgn:F2}");

    return 0;
}

