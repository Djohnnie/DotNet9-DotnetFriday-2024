
await Method();



async Task Method()
{
    byte[] numbers = { 1, 2, 3, 4, 5 };

    await Task.Delay(1000);

    ref byte lastNumber = ref GetLast(numbers);

    lastNumber = 6;
}

//IEnumerable<int> Iterator()
//{
//    byte[] numbers = { 1, 2, 3, 4, 5 };

//    ref byte lastNumber = ref GetLast(numbers);

//    yield return lastNumber;

//    lastNumber = 6;
//}


ref byte GetLast(byte[] numbers)
{
    return ref numbers[^1];
}