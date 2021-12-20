// Tries

// Trie Node
class TrieNode {
    constructor(val){
        // This value is a single letter
        this.val = val;
        this.isWord = false;
        // children
        this.children = new Array(26).fill(null);
        // [null, null, null, null, null, null, null, null,...]
        //   0    1      2     3     4     5     6     7 
    }
}

class Trie {
    constructor(){
        this.root = new TrieNode("");
    }
    // Add a word to our trie
    add(word){
        // Start at our root
        let runner = this.root;
        // safety check, make sure all my letters are lowercase
        word = word.toLowerCase();
        // I need to go through my letters and find or add each of them in individually
        // Step one: loop through my word
        for(let letter = 0; letter < word.length; letter++)
        {
            // My children are built on an array that is structured to keep all my letters in alphabetical order
            // So, for example, "c" would be located at index 2
            // So if I look at children[2] I would expect to see either TrieNode(c) OR null
            // First: identify where the letter SHOULD be
            let index = word[letter].charCodeAt(0) - 97;
            // console.log(index);
            // Second: find out if anything is at that location
            if(runner.children[index] == null){
                // If it is equal to null, nothing is there, which means I need to add the value in
                console.log(`The letter ${word[letter]} was not present. Adding new trieNode now`);
                runner.children[index] = new TrieNode(word[letter]);
            }
            // Third: I want to move down to that letter in the child array
            runner = runner.children[index];
        }
        runner.isWord = true;
        console.log(`${word} was added successfully`);
    }
}

var myTrie = new Trie();
myTrie.add("CAR");
myTrie.add("CAT");
myTrie.add("APPLE");
myTrie.add("APE");