// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLMessageMediaEmpty : TLMessageMediaBase 
	{
		public TLMessageMediaEmpty() { }
		public TLMessageMediaEmpty(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageMediaEmpty; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
		}
	}
}