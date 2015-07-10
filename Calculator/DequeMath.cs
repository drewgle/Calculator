﻿using System;
using System.Collections.Generic;

namespace Calculator
{
  internal static class DequeMath
  {
	internal static void AddInPlace(this Stack<double> _queue)
	{
	  double left;
	  double right;
	  double result;

	  if (_queue.Count < 2)
	  {
		throw new StackUnderflowException();
	  }

	  right = _queue.Pop();
	  left = _queue.Pop();

	  checked
	  {
		result = left + right;
	  }
	  _queue.Push(result);
	}
	internal static void SubtractInPlace(this Stack<double> _queue)
	{
	  double left;
	  double right;
	  double result;

	  if (_queue.Count < 2)
	  {
		throw new StackUnderflowException();
	  }

	  right = _queue.Pop();
	  left = _queue.Pop();
	  checked
	  {
		result = left - right;
	  }
	  _queue.Push(result);
	}
	internal static void MultiplyInPlace(this Stack<double> _queue)
	{
	  double left;
	  double right;
	  double result;
	  
	  if (_queue.Count < 2)
	  {
		throw new StackUnderflowException();
	  }

	  right = _queue.Pop();
	  left = _queue.Pop();
	  checked
	  {
		result = left * right;
	  }
	  _queue.Push(result);
	}
	internal static void DivideInPlace(this Stack<double> _queue)
	{
	  double left;
	  double right;
	  double result;

	  if (_queue.Count < 2)
	  {
		throw new StackUnderflowException();
	  }

	  right = _queue.Pop();
	  left = _queue.Pop();

	  if (right == 0)
		throw new DivideByZeroException();

	  checked
	  {
		result = left / right;
	  }
	  _queue.Push(result);
	}

	internal static void PowInPlace(this Stack<double> _queue)
	{
	  double left;
	  double right;
	  double result;

	  if (_queue.Count < 2)
	  {
		throw new StackUnderflowException();
	  }

	  right = _queue.Pop();
	  left = _queue.Pop();

	  if (right == 0)
		throw new DivideByZeroException();

	  checked
	  {
		result = Math.Pow(left,right);
	  }
	  _queue.Push(result);
	}
  }
}