using System;
using System.Collections.Generic;
using System.Text;

namespace CG_11_1
{
    class Student
    {
        public List<int> scores = new List<int>();
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }

        public void AddScore(int score)
        {
            scores.Add(score);
        }

        public bool SixOrGreater()
        {
            return scores.Count >= 7;
        }




    }


}
