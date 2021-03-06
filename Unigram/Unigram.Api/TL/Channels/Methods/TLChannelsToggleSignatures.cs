// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Channels.Methods
{
	/// <summary>
	/// RCP method channels.toggleSignatures.
	/// Returns <see cref="Telegram.Api.TL.TLUpdatesBase"/>
	/// </summary>
	public partial class TLChannelsToggleSignatures : TLObject
	{
		public TLInputChannelBase Channel { get; set; }
		public Boolean Enabled { get; set; }

		public TLChannelsToggleSignatures() { }
		public TLChannelsToggleSignatures(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelsToggleSignatures; } }

		public override void Read(TLBinaryReader from)
		{
			Channel = TLFactory.Read<TLInputChannelBase>(from);
			Enabled = from.ReadBoolean();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Channel);
			to.WriteBoolean(Enabled);
		}
	}
}