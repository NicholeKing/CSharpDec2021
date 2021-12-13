// Splice

var arr = [1,2,3,4,5];

function mySplice(arr, idx, valsToRem){
    for(var i = idx; i < arr.length; i++){
        arr[i] = arr[i+valsToRem];
    }
    arr.length = arr.length - valsToRem;
    return arr;
}

console.log(mySplice(arr, 1, 2));
