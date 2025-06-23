using System.Collections.Generic;
using UnityEngine;

public class StudyInheritance : MonoBehaviour
{
    public List<T2ownPerson> people = new List<T2ownPerson>();

    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Student student = new Student();
            people.Add(student);

            Soldier soldier = new Soldier();
            people.Add(soldier);
        }
    }

    public void AllMove()
    {
        foreach (var person in people)
            person.walk();
    }
}
