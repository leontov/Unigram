// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Channels
{
	public partial class TLChannelsChannelParticipant : TLObject 
	{
		public TLChannelParticipantBase Participant { get; set; }
		public TLVector<TLUserBase> Users { get; set; }

		public TLChannelsChannelParticipant() { }
		public TLChannelsChannelParticipant(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelsChannelParticipant; } }

		public override void Read(TLBinaryReader from)
		{
			Participant = TLFactory.Read<TLChannelParticipantBase>(from);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Participant);
			to.WriteObject(Users);
		}
	}
}