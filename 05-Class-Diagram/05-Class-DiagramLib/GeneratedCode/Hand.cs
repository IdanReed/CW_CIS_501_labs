﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Hand
{
	private List<Card> h
	{
		get;
		set;
	}

	public virtual IEnumerable<Card> Card
	{
		get;
		set;
	}

	public virtual void add(Card c)
	{
        h.Add(c);
    }

	public virtual bool remove(Count c, Suit s)
	{
        bool ok = false;
        foreach (Card cd in h)
        {
            if (cd.count == c && cd.suit == s)
            {
                h.Remove(cd); ok = true;
                break;
            }
        }
        return ok;
    }

	public virtual int howManyCards()
	{
        return h.Count;
    }

	public virtual int BJscore()
	{
        int result = 0;
        foreach (Card c in h)
        {
            result += c.BJvalue();
        }
        return result;
    }

	public virtual string ToString()
	{
        string ans = "";
        foreach (Card c in h)
        {
            ans = ans + c.ToString() + "\n";
        }
        return ans;
    }

}
