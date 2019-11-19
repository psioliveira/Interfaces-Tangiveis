using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionParser 
{
    List<Question> QuestionList;
    Question temp;
    public List<Question> Parse()
    {
        temp = new Question(10, 2, 4, 120);
        QuestionList.Add(temp);
        temp = new Question(10, 2, 4, 120);
        QuestionList.Add(temp);
        return QuestionList;
    }

}
