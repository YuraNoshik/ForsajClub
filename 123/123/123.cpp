#include <stdio.h>
#include <stdlib.h>
int main()
{
    float x0, y0;
    printf("x0, y0: ");
    scanf("%f %f", &x0, &y0);

    float v0x, v0y;
    printf("v0x, v0y: ");
    scanf("%f %f", &v0x, &v0y);

    float ax, ay;
    printf("ax, ay: ");
    scanf("%f %f", &ax, &ay);

    float t;
    printf("t : ");
    scanf("%f", &t);


    float x = x0 + v0x * t + ax * t * t / 2.0f;
    float y = y0 + v0y * t + ay * t * t / 2.0f;


    printf("x: %.3f\n", x);
    printf("y: %.3f\n", y);

    return 0;
}
