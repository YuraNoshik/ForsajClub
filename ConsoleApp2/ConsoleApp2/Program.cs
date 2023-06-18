#include <stdio.h>

int main()
{
    float x0;
    float v0x, ax;
    float t;

    scanf("%f %f %f %f", &x0, &v0x, &ax, &t);

    float x = x0 + v0x * t + ax * t * t / 2.0f;

    printf("x: %.3f\n", x);

    return 0;
}

