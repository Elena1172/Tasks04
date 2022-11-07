//Задача 25: Напишите цикл, который принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3?)   2, 4 -> 16
double ToDegree(int a, int b){
    double n = 1;
    if(b == 0) return n;
    else if (b > 0){
        for(int i = 1; i < b+1;i++){
            n = n * a;
        }
        return n;
        }
    
    else {
        b = Math.Abs(b);
        for(int i = 1; i < b+1;i++){
            n = n * a;
        }
        n = 1 / n;
        return Math.Round(n,4);
}
}
Console.WriteLine("Введите два целых числа");
Console.Write("Число А =  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Число B =  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Число А = {m} в степени числа В = {n}  =>  {ToDegree(m,n)}");
