// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Messages
{
	public partial class TLMessagesChatsSlice : TLMessagesChatsBase 
	{
		public Int32 Count { get; set; }

		public TLMessagesChatsSlice() { }
		public TLMessagesChatsSlice(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesChatsSlice; } }

		public override void Read(TLBinaryReader from)
		{
			Count = from.ReadInt32();
			Chats = TLFactory.Read<TLVector<TLChatBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(Count);
			to.WriteObject(Chats);
		}
	}
}