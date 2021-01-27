using System;

namespace Record
{
	public sealed class PointClass : IEquatable<PointClass>, ICloneable
	{
		public double X { get; }
		public double Y { get; }

		public PointClass(double x, double y)
		{
			X = x;
			Y = y;
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as PointClass);
		}

		public bool Equals(PointClass other)
		{
			return other != null &&
				   X == other.X &&
				   Y == other.Y;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(X, Y);
		}

		public object Clone()
		{
			return new PointClass(X, Y);
		}
	}
}
