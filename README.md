# A* in Unity (C#)
In an effort to practice my algorithm skills and to create some code that can be reused for my games, I have decided to implement the A* pathfinding algorithm in Unity. Prior to this small project, I have had a brief introduction to AI pathfinding algorithms from my Intro to AI undergraduate course. 

## A* overview

### Equation
*f(n) = g(n) + h(n)*

Where:

*f(n)* = total estimated cost of path through node 

*g(n)* = cost so far to read node n

*h(n)* = heuristic function. Estimated cost from n to the goal

### Heuristic functions

In A*, the heuristic function must be admissible. Meaning that it never overestimates the cost to reach the goal.

Manhattan distance heuristic and euclidean distance heuristic are commonly used with the A* pathfinding algorithm.

#### Manhattan Distance

Horizontal/Vertical move cost = 1

Diagonal move cost = sqrt(2) = aprox. 1.41


As long as the heuristic is admissible, then the A* search is both complete and optimal.

## Details

1. Begin in starting node, and look at all surrounding nodes to calculate values for them [g(n)+h(n)]. Values of nodes shall be cached to avoid being calculated more than once.

    Remember: g(n) = distance from starting node. h(n) = distance from goal

2. After f(n) has been calculated for all neighboring nodes, select node with smallest value. This node object will be held as the current node. If multiple nodes have equal f(n) values, the node with lowest h(n) value will be chosen (if multiple h(n) are equal, choose randomly)

3. Continue the process provided in 1 & 2, until a path to the goal has been found.

4. Once the goal has been reached, trace back the path to start to get full path.
