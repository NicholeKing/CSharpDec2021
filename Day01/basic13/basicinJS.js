function PrintNumbers()
{
    // Print all of the integers from 1 to 255.
    for(var i = 1; i <= 255; i++){
        console.log(i);
    }
}

// PrintNumbers();

function PrintOdds()
{
    // Print all of the odd integers from 1 to 255.
    for(var i = 1; i <= 255; i++){
        if(i % 2 != 0){
            console.log(i);
        }
    }
}
// PrintOdds();

function PrintSum()
{
    // Print all of the numbers from 0 to 255, 
    // but this time, also print the sum as you go. 
    // For example, your output should be something like this:
    
    // New number: 0 Sum: 0
    // New number: 1 Sum: 1
    // New Number: 2 Sum: 3
    total = 0;
    for(var i = 0; i <= 255; i++){
        total+=i;
        console.log("New Number:", i, "Sum:",  total);
    }
}

// PrintSum();

function LoopArray(numbers)
{
    // Write a function that would iterate through each item of the given integer array and 
    // print each value to the console. 
    for(var i = 0; i < numbers.length; i++){
        console.log(numbers[i]);
    }
}

// LoopArray([1,2,3,4,5,6]);

function FindMax(numbers)
{
    // Write a function that takes an integer array and prints and returns the maximum value in the array. 
    // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
    // or even a mix of positive numbers, negative numbers and zero.
    var max = numbers[0];
    if(numbers.length == 1){
        max = numbers[0];
    }
    for(var i = 0; i < numbers.length; i++){
        if(numbers[i] > max){
            max = numbers[i];
        }
    }
    console.log(max);
}

// FindMax([-2,-3,-4,-1,-5]);

function GetAverage(numbers)
{
    // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
    // For example, with an array [2, 10, 3], your program should write 5 to the console.
    // Average = sum / # of #'s
    // # of #'s = Length
    // We know how to get sum
    // step 1, find the sum
    var sum = 0;
    for(var i = 0; i < numbers.length; i++){
        sum+=numbers[i];
    }
    console.log(sum/numbers.length);
}

// GetAverage([2,10,3]);

function OddArray()
{
    // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
    // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
    var arr = [];
    for(var i = 1; i <= 255; i++){
        if(i % 2 != 0){
            arr.push(i);
        }
    }
    console.log(arr);
}

// OddArray();

function GreaterThanY(numbers, y)
{
    // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
    // That are greater than the "y" value. 
    // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
    // (since there are two values in the array that are greater than 3).
    var count = 0;
    for(var i = 0; i < numbers.length; i++){
        if(y < numbers[i]){
            count++;
        }
    }
    console.log(count);
}

GreaterThanY([2,3,4,7,8], 3);