#include "variadic_functions.h"

/**
 * print_numbers - function that prints numbers, followed by a new line.
 * @separator: is the string to be printed between numbers
 * @n: the number of integers passed to the function
 * 
 * Return : void
*/

void print_numbers(const char *separator, const unsigned int n, ...)
{
    va_list arg;
    unsigned int i;

    va_start(arg, n);

    if (!*separator)
    {
        for (i = 0; i < n; i++)
        {
            printf("%d", va_arg(arg, unsigned int));
        }
        printf("\n");
    }
    else
    {
        for (i = 0; i < n; i++)
        {
            printf("%d", va_arg(arg, unsigned int));
            if (i != n-1)
                printf("%s",separator);
        }
        printf("\n");
    }

    va_end(arg);
}