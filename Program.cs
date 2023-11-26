using BinaryTreeMaxDepth;

// Step 1: Create individual nodes
TreeNode root = new TreeNode(3);
TreeNode node9 = new TreeNode(9); // This node has no children
TreeNode node20 = new TreeNode(20);
TreeNode node15 = new TreeNode(15); // This node has no children
TreeNode node7 = new TreeNode(7);   // This node has no children

// Step 2: Link the nodes to form the tree
root.left = node9;
root.right = node20;
node20.left = node15;
node20.right = node7;

Console.WriteLine(root.MaxDepth(root));