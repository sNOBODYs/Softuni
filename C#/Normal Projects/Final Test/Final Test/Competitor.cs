using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Final_Test
{
    class Competitor<T> : IEnumerable<T>
    {
        private string privateName;
        private int privateAge;
        public List<T> Scores;

        public string Name
        {
            get => privateName;
            set => privateName = value;
        }
        public int Age
        {
            get => privateAge;
            set
            {
                if (value < 10)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be less than 10");
                }

                privateAge = value;
            }
        }

        public Competitor(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Scores = new List<T>();
        }

        public void Add(T score)
        {
            Scores.Add(score);
        }

        public int CountCompetitions()
        {
            return Scores.Count;
        }

        public T ChangeLastScore(T newScore)
        {
            T sumScore = Scores[Scores.Count - 1];
            Scores[Scores.Count - 1] = newScore;
            return sumScore;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Scores.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(Competitor<T> other)
        {
            //първо по име 
            int result = this.Name.CompareTo(other.Name);
            // ако е вярно , по възраст
            if (result == 0)
            {
                if (this.Age != other.Age)
                {
                    return (this.Age - other.Age);
                }
                else
                {
                    return 0;
                }
            }
                return result;
        }
    }
}
