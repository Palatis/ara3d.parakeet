using System.Runtime.CompilerServices;
using Ara3D.Utils;

namespace Ara3D.Parakeet
{
    /// <summary>
    /// A class that represents the state of the parser, and the parse tree. 
    /// </summary>
    public class ParserState : ILocation
    {
        public readonly ParserInput Input;
        public readonly int Position;
        public readonly ParserNode Node;
        public readonly ParserError LastError;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ParserRange GetRange()
            => new ParserRange(null, this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool AtEnd()
            => Position >= Input.Length;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char GetCurrent()
            => Input[Position];

        public ParserState(ParserInput input, int position = 0, ParserNode node = null, ParserError error = null)
            => (Input, Position, Node, LastError) = (input, position, node, error);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ParserState Advance(int amount)
            => new ParserState(Input, Position + amount, Node, LastError);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ParserState Advance()
            => new ParserState(Input, Position + 1, Node, LastError);

        public ParserState JumpToEnd()
            => Advance(CharsLeft);

        public override string ToString()
            => $"Ln:{LineIndex} Ch:{Column} Pos:{Position}/{Input.Length} Node:{Node}";

        public int LineIndex
            => Input.GetLineIndex(Position);

        public int Column
            => Input.GetColumn(Position);

        public string CurrentLine
            => Input.GetLine(LineIndex);

        public string Indicator
            => Input.GetIndicator(Position);

        public ParserState ClearNodes()
            => new ParserState(Input, Position);

        public ParserState WithError(ParserError error)
            => new ParserState(Input, Position, Node, error);

        public int CharsLeft
            => Input.Length - Position;

        public override bool Equals(object obj)
            => obj is ParserState ps && Equals(ps);

        public bool Equals(ParserState state)
            => (state != null) && Position == state.Position;
        
        public ParserState AddNode(string name, ParserState prev)
            => new ParserState(Input, Position, new ParserNode(name, ParserRange.Create(prev, this), Node), LastError);

        public override int GetHashCode()
            => Position.GetHashCode();
    }
}