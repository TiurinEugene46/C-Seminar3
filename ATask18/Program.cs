// Определение четверти точки
string GetAreaRange(int areaNum)
{
    if (areaNum == 1){
        return  "x > 0 y > 0";
    }
    if (areaNum == 2){
        return "x < 0 y > 0";
    }
    if (areaNum == 3){
     return "x < 0 y < 0";
    }
    if (areaNum == 4){
        return "x > 0 y < 0";
    }
    if(areaNum == 0){
        return "x = 0 y = 0";
    }

    return "Введите номер четверти больше 4-х";
}

Console.Write("Введите число: ");
int areaNum = Convert.ToInt32(Console.ReadLine());

string result = GetAreaRange(areaNum);
Console.Write(result);
