// Binary Search Trees

// Node
class BNode {
    constructor(value){
        this.value = value;
        this.right = null;
        this.left = null;
    }
}

// Binary Search Tree class
class BST {
    constructor(){
        // Just like with head or tail we can't assume there is a value already so we start it at null
        this.root = null;
    }
    // Checking to see if the tree is empty
    isEmpty(){
        return this.root == null;
    }

    // Add to tree
    // Case 1: there is nothing in the tree -> then the value to add becomes the root
    // Case 2: this is something, so we have to figure out which direction to go
    // Ask which direction to go, we need a while loop to allow us to keep asking this question until we hit a null
    // Assuming we are passing a numeric value in, NOT a node
    add(newVal){
        const node = new BNode(newVal);
        // First, check if it's empty
        if(this.isEmpty()){
            this.root = node;
        } else {
            let runner = this.root;
            while(true){
                // check if the value is smaller
                if(this.runner.value > newVal){
                    // Need to check if there is null to the left
                    if(this.runner.left == null){
                        this.runner.left = node;
                        return this;
                    }
                    // We need to go to the left
                    runner = runner.left;
                } else {
                    // runner is SMALLER than our value
                    // Need to check if there is null to the right
                    if(this.runner.right == null){
                        this.runner.right = node;
                        return this;
                    }
                    // we need to go to the right
                    runner = runner.right;
                }
            }
        }
    }

    // How would we get the smallest value from this BST?
    min(){
        // the value is located at the very bottom left
        // Need a while loop to take us down to the leftmost value
        // Edge case: there is nothing in the tree, therefore there is no leftmost value
        if(this.isEmpty())
        {
            return null;
        } else {
            let runner = this.root;
            while(runner.left){
                runner = runner.left;
            }
            return runner.value;
        }
    }

    max(){
        if(this.isEmpty())
        {
            return null;
        } else {
            let runner = this.root;
            while(runner.right){
                runner = runner.right;
            }
            return runner.value;
        }
    }
}