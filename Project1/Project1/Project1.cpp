
#include <stdio.h>
#include <stdlib.h>
int main()
{
    int N;
    printf("Кличество оценок:\n ");
    scanf_s("%d", &N);
    float sum;
    float avg;
    int *m = new int[N];
    printf("Ввод оценок:\n ");
    for (int i = 0; i < N; i++)
    {
        scanf_s("%d", &m[i]);

        if (m[i] < 2 || m[i]>5)
        {
            printf("Неверно введена оценка\n");
        }
        sum = +m[i];
    }
    avg = sum / N;
    printf("Средний балл аттестата\n", avg);
    if (avg >= 4.6)
    {
        printf("Ученик поступит с таким баллом аттестата");
    }
    else
    {
        printf("Ученик не поступит с таким баллом аттестата");
    }
    

    return 0;
}
