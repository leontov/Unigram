// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLBotInlineMessageMediaContact : TLBotInlineMessageBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			ReplyMarkup = (1 << 2),
		}

		public bool HasReplyMarkup { get { return Flags.HasFlag(Flag.ReplyMarkup); } set { Flags = value ? (Flags | Flag.ReplyMarkup) : (Flags & ~Flag.ReplyMarkup); } }

		public Flag Flags { get; set; }
		public String PhoneNumber { get; set; }
		public String FirstName { get; set; }
		public String LastName { get; set; }

		public TLBotInlineMessageMediaContact() { }
		public TLBotInlineMessageMediaContact(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.BotInlineMessageMediaContact; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			PhoneNumber = from.ReadString();
			FirstName = from.ReadString();
			LastName = from.ReadString();
			if (HasReplyMarkup) ReplyMarkup = TLFactory.Read<TLReplyMarkupBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			to.WriteString(PhoneNumber ?? string.Empty);
			to.WriteString(FirstName ?? string.Empty);
			to.WriteString(LastName ?? string.Empty);
			if (HasReplyMarkup) to.WriteObject(ReplyMarkup);
		}

		private void UpdateFlags()
		{
			HasReplyMarkup = ReplyMarkup != null;
		}
	}
}