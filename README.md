# ИТОГОВАЯ РАБОТА

## ЗАДАНИЕ:

>*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше либо равна 3 символам.*

### ССЫЛКА НА РЕПОЗИТОРИЙ:
https://github.com/Makcmay/FINAL_C/ 



### ОПИСАНИЕ РЕШЕНИЯ:

1.	Пользователь вводит произвольное количество символов через пробел.
2.	Веденая строка преобразуется в массив строк array по разделителю "пробел".
3.	Происходит проверка по длине введённой строки, если длинна равна нулю, то программа завершается. Если сиволы введены, то программа продолжает выполняться.
4.	Вводится новый пустой массив result с размером начального массива.
5.	Вводим переменную size для присвоения индекса, подходящим под условия задачи элементам из исходного массива array в итоговом массиве result.
6.	Проходимся по всем элементам начального массива и проверяем их на предмет соответствия заданному условию, длинна меньше либо равна трем символам.
7.	В случае если элемент соответствует условию, добавляем его в итоговый массив.
8.	Выводим на экран элементы итогового массива каждый элемент с новой строки, начиная с первого элемента массива result с индексом [0] в количестве равном размеру итогового массива.
9. Выполнение программы останавливается пока пользователь не нажмет любую клавишу.
10. После нажатия клавиши программа завершается.

