using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControllerScript : MonoBehaviour
{
    public List<Shape> gameShapes;
    public Dictionary<string, Shape> shapeDictionary;
    public Queue<Shape> shapeQueue;
    public Stack<Shape> shapesStack;

    void Start()
    {
        shapeQueue = new Queue<Shape>();
        shapeDictionary = new Dictionary<string, Shape>();
        shapesStack = new Stack<Shape>();

        foreach (Shape shape in gameShapes)
        {
            shapeDictionary.Add(shape.Name, shape);
        }

        shapeQueue.Enqueue(shapeDictionary["Triangle"]);
        shapeQueue.Enqueue(shapeDictionary["Square"]);
        shapeQueue.Enqueue(shapeDictionary["Octagon"]);
        shapeQueue.Enqueue(shapeDictionary["Circle"]);

        shapesStack.Push(shapeDictionary["Triangle"]);
        shapesStack.Push(shapeDictionary["Square"]);
        shapesStack.Push(shapeDictionary["Octagon"]);
        shapesStack.Push(shapeDictionary["Circle"]);

        // shapeDictionary.Add("Octagon", octagon);
        // shapeDictionary["Octagon"].SetColor(Color.red);

        //octagon.SetColor(Color.red);
    }

    private void SetRedByName(string shapeName)
    {
        shapeDictionary[shapeName].SetColor(Color.red);
    }
    private void FindExample()
    {
        Shape octagon = gameShapes.Find(s => s.Name == "Octagon");
        shapeDictionary["Octagon"].SetColor(Color.red);
    }
    private void ListExample()
    {
        string[] shapes = { "circle", "square", "triangle", "octagon" };
        List<string> moreShapes = new List<string> { "circle", "square", "triangle", "octagon" };
        moreShapes.Add("rectangle");
        moreShapes.Insert(2, "diamond");
        moreShapes.Sort();

        for (int i = 0; i < moreShapes.Count; i++)
        {
            moreShapes[i] = moreShapes[i].ToUpper();
            Debug.Log(moreShapes[i]);
        }
    }
    private void DeQueueExample()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (shapeQueue.Count > 0)
            {
                Shape shape = shapeQueue.Dequeue();
                shape.SetColor(Color.blue);
            }

            else
            {
                Debug.Log("The shape queue is empty");
            }
        }
    }
    private void DictionaryExample()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SetRedByName("Square");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            SetRedByName("Circle");
        }
    }
    private void StackExample()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (shapesStack.Count > 0)
            {
                Shape shape = shapesStack.Pop();
                shape.SetColor(Color.green);
            }

            else
            {
                Debug.Log("The shape stack is empty");
            }
        }
    }

    void Update()
    {

    }
}
