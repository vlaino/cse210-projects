using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score;
    private int _count = 0;
    private string _folder = "savefolder/";

    public GoalManager()
    {

    }

    public void Start()
    {
        string menu = "\nMenu Options:\n1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Quit";
        bool options = true;

        do
        {
            DisplayPlayerInfo();
            Console.WriteLine(menu);
            Console.Write("Select a choice from the menu: ");
            int user = int.Parse(Console.ReadLine());

            if (user == 1)
            {
                CreateGoal();
            }
            else if (user == 2)
            {
                Console.WriteLine("");
                ListGoalDetails();
            }
            else if (user == 3)
            {
                SaveGoal();
            }
            else if (user == 4)
            {
                LoadGoals();
            }
            else if (user == 5)
            {
                RecordEvent();
            }
            else if (user == 6)
            {
                options = false;
                break;
            }
            
        }
        while (options);
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points");
    }

    private void ListGoalNames()
    {
        if (_goals.Count != 0)
        {
            foreach (Goal goal in _goals)
            {
                _count++;
                Console.WriteLine($"{_count}. {goal.GetName()}");
            }
            _count = 0;
        }
        else
        {
            Console.WriteLine("The list of goals is empty. Either load your saved goals or create new ones.");
        }
    }

    private void ListGoalDetails()
    {
        if (_goals.Count !=0)
        {
            foreach (Goal goal in _goals)
            {
                _count++;
                Console.WriteLine($"{_count}. {goal.GetDetailsString()}");
            }
            _count = 0;
        }
        else
        {
            Console.WriteLine("The list of goals is empty. Either load your saved goals or create new ones.");
        }
    }

    private void CreateGoal()
    {
        string [] goalTypes = {"Simple Goal", "Eternal Goal", "Checklist Goals"};
        Console.WriteLine($"\nThe types of goals are:\n1. {goalTypes[0]}\n2. {goalTypes[1]}\n3. {goalTypes[2]}");
        Console.Write("What type of goal would you like to create?: ");
        int type = int.Parse(Console.ReadLine()) - 1;

        if (type == 0)
        {
            SimpleGoal simpleGoal = new(name: GoalName(), description: GoalDescription(), points: GoalPoint(), goal: goalTypes[type]);
            _goals.Add(simpleGoal);
        }
        else if (type == 1)
        {
            EternalGoal eternalGoal = new(name: GoalName(), description: GoalDescription(), points: GoalPoint(), goal: goalTypes[type]);
            _goals.Add(eternalGoal);
        }
        else if (type == 2)
        {
            ChecklistGoal checklistGoal = new(name: GoalName(), description: GoalDescription(), points: GoalPoint(), goal: goalTypes[type], target: CheckListCount(), bonus: BonusPoint());
            _goals.Add(checklistGoal);
        }
        else
        {
            Console.WriteLine("Invalid: This option does not exist");
        }
    }

    private void RecordEvent()
    {
        ListGoalNames();
        Console.Write("\nWhich goal did you accomplished? ");
        int index = int.Parse(Console.ReadLine());

        Goal goalAccomplished = _goals[index - 1];
        goalAccomplished.IsCompleteToTrue();
        goalAccomplished.RecordEvent();
        _score += goalAccomplished.GetCurrentPoint();

        string message =$"Congratulations! You have earned {goalAccomplished.GetPoints()} points";
        string message1 = $"You now have {_score} points.";
        Console.WriteLine(message);
        Console.WriteLine(message1);
    }
    
    private void SaveGoal()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using StreamWriter saveGoals = new($"{fileName}.txt");
        saveGoals.WriteLine(_score);
        foreach (Goal goal in _goals)
        {
            saveGoals.WriteLine(goal.GetStringRepresentation());
        }
        _goals.Clear();
    }

    private void LoadGoals()
    {
        string[] files = System.IO.Directory.GetFiles(_folder);

        if (files.Length != 0)
        {
            Console.WriteLine("These are saved files:");
            foreach (string file in files)
            {
                _count++;
                Console.WriteLine($"{_count}.{Path.GetFileNameWithoutExtension(file)}");
            }
            _count = 0;

            Console.Write("Choose the file to load (by it number): ");
            int chooseFile = int.Parse(Console.ReadLine());
            string[] fileContent = File.ReadAllLines(files[chooseFile - 1]);

            _goals.AddRange(ConvertToGoalObjects(fileContent));
        }
        else Console.WriteLine("There are no files saved in your Saved-Folder");
    }

    private string GoalName()
    {
        Console.Write("What is the name of your goal? : ");
        string _goalname = Console.ReadLine();
        return _goalname;
    }

    private int GoalPoint()
    {
        Console.Write("What is the amount of points associated with this goal?");
        int _goalPoint = int.Parse(Console.ReadLine());
        return _goalPoint;
    }

    private string GoalDescription()
    {
        Console.Write("What is a short description of it?: ");
        string _goalDescription = Console.ReadLine();
        return _goalDescription;
    }

    private int BonusPoint()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        int _bonusPoint = int.Parse(Console.ReadLine());
        return _bonusPoint;
    }

    private int CheckListCount()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? : ");
        int _checklistCount = int.Parse(Console.ReadLine());
        return _checklistCount;
    }
    
    private List<Goal> ConvertToGoalObjects(string[] param)
    {
        _score = int.Parse(param[0]);
        char colon = ':';
        char pipe = '|';
        int start = 1;
        int end = param.Length;
        param = param.Where((value, index) => index >= start && index <= end).ToArray();

        List<Goal> initialGoal = new();

        foreach (string list in param)
        {
            string[] parts = list.Split(colon);
            string goalName = parts[0].Trim();
            string[] contents = parts[1].Split(pipe);

            if (goalName == "Simple Goal")
            {
                SimpleGoal simpleGoal = new(name: contents[0].Trim(), description: contents[1].Trim(), points: int.Parse(contents[2].Trim()), goal: goalName);
                bool isComplete = bool.Parse(contents[3]);
                if (isComplete) 
                {
                    simpleGoal.CheckMark();
                    simpleGoal.IsCompleteToTrue();
                }
                initialGoal.Add(simpleGoal);
            }
            if (goalName == "Eternal Goals")
            {
                EternalGoal eternalGoal = new (name: contents[0].Trim(), description: contents[1].Trim(), points: int.Parse(contents[2].Trim()), goal: goalName);
                initialGoal.Add(eternalGoal);
            }
            if (goalName == "Checklist Goals")
            {
                ChecklistGoal checklistGoal = new(name: contents[0].Trim(), description: contents[1].Trim(), points: int.Parse(contents[2].Trim()), goal: goalName, bonus: int.Parse(contents[3].Trim()), target: int.Parse(contents[4].Trim()));
                bool isComplete = bool.Parse(contents[6]);
                if (isComplete)
                {
                    checklistGoal.CheckMark();
                    checklistGoal.IsCompleteToTrue();
                } 
                checklistGoal.AddAmountCompleted(int.Parse(contents[5].Trim()));
                initialGoal.Add(checklistGoal);
            }
        }
        Console.WriteLine("\nFile loaded successfully");
        return initialGoal;
    }

}