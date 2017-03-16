using System;
using System.Collections.Generic;
using System.Text;

namespace KeraLua
{
	public struct LuaState :IEquatable<LuaState>
	{
		public LuaState (IntPtr ptrState)

			: this ()
		{
			state = ptrState;
		}

		static public implicit operator LuaState (IntPtr ptr)
		{
			return new LuaState (ptr);
		}

		static public implicit operator IntPtr (LuaState luastate)
		{
			return luastate.state;
		}

		public override int GetHashCode()
		{
			return state.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			return state.Equals(obj);
		}

		bool IEquatable<LuaState>.Equals(LuaState other)
		{
			return state == other.state;
		}

		IntPtr state;
	}
}
