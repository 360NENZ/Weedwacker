// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AllWidgetDataNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AllWidgetDataNotify.proto</summary>
  public static partial class AllWidgetDataNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for AllWidgetDataNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AllWidgetDataNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlBbGxXaWRnZXREYXRhTm90aWZ5LnByb3RvGhVBbmNob3JQb2ludERhdGEu",
            "cHJvdG8aGUNsaWVudENvbGxlY3RvckRhdGEucHJvdG8aEkx1bmNoQm94RGF0",
            "YS5wcm90bxoiT25lb2ZHYXRoZXJQb2ludERldGVjdG9yRGF0YS5wcm90bxoZ",
            "VW5rMjcwMF9DQ0VPRU9ITEFQSy5wcm90bxoYV2lkZ2V0Q29vbERvd25EYXRh",
            "LnByb3RvGhRXaWRnZXRTbG90RGF0YS5wcm90byL9AwoTQWxsV2lkZ2V0RGF0",
            "YU5vdGlmeRIbChNVbmszMDAwX0NOTkZHRkJCQkZQGAsgAygNEiUKDmx1bmNo",
            "X2JveF9kYXRhGAEgASgLMg0uTHVuY2hCb3hEYXRhEjYKGWNvb2xfZG93bl9n",
            "cm91cF9kYXRhX2xpc3QYDSADKAsyEy5XaWRnZXRDb29sRG93bkRhdGESKwoR",
            "YW5jaG9yX3BvaW50X2xpc3QYAyADKAsyEC5BbmNob3JQb2ludERhdGESIgoJ",
            "c2xvdF9saXN0GAYgAygLMg8uV2lkZ2V0U2xvdERhdGESJQodbmV4dF9hbmNo",
            "b3JfcG9pbnRfdXNhYmxlX3RpbWUYCiABKA0SOAoaY2xpZW50X2NvbGxlY3Rv",
            "cl9kYXRhX2xpc3QYBCADKAsyFC5DbGllbnRDb2xsZWN0b3JEYXRhEkwKJW9u",
            "ZW9mX2dhdGhlcl9wb2ludF9kZXRlY3Rvcl9kYXRhX2xpc3QYDyADKAsyHS5P",
            "bmVvZkdhdGhlclBvaW50RGV0ZWN0b3JEYXRhEjcKGm5vcm1hbF9jb29sX2Rv",
            "d25fZGF0YV9saXN0GAkgAygLMhMuV2lkZ2V0Q29vbERvd25EYXRhEjEKE1Vu",
            "azI3MDBfQ09JRUxJR0VBQ0wYDCABKAsyFC5VbmsyNzAwX0NDRU9FT0hMQVBL",
            "QiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.AnchorPointDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ClientCollectorDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.LunchBoxDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.OneofGatherPointDetectorDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.Unk2700CCEOEOHLAPKReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.WidgetCoolDownDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.WidgetSlotDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.AllWidgetDataNotify), global::Weedwacker.Shared.Network.Proto.AllWidgetDataNotify.Parser, new[]{ "Unk3000CNNFGFBBBFP", "LunchBoxData", "CoolDownGroupDataList", "AnchorPointList", "SlotList", "NextAnchorPointUsableTime", "ClientCollectorDataList", "OneofGatherPointDetectorDataList", "NormalCoolDownDataList", "Unk2700COIELIGEACL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 4271
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class AllWidgetDataNotify : pb::IMessage<AllWidgetDataNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AllWidgetDataNotify> _parser = new pb::MessageParser<AllWidgetDataNotify>(() => new AllWidgetDataNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AllWidgetDataNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.AllWidgetDataNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AllWidgetDataNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AllWidgetDataNotify(AllWidgetDataNotify other) : this() {
      unk3000CNNFGFBBBFP_ = other.unk3000CNNFGFBBBFP_.Clone();
      lunchBoxData_ = other.lunchBoxData_ != null ? other.lunchBoxData_.Clone() : null;
      coolDownGroupDataList_ = other.coolDownGroupDataList_.Clone();
      anchorPointList_ = other.anchorPointList_.Clone();
      slotList_ = other.slotList_.Clone();
      nextAnchorPointUsableTime_ = other.nextAnchorPointUsableTime_;
      clientCollectorDataList_ = other.clientCollectorDataList_.Clone();
      oneofGatherPointDetectorDataList_ = other.oneofGatherPointDetectorDataList_.Clone();
      normalCoolDownDataList_ = other.normalCoolDownDataList_.Clone();
      unk2700COIELIGEACL_ = other.unk2700COIELIGEACL_ != null ? other.unk2700COIELIGEACL_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AllWidgetDataNotify Clone() {
      return new AllWidgetDataNotify(this);
    }

    /// <summary>Field number for the "Unk3000_CNNFGFBBBFP" field.</summary>
    public const int Unk3000CNNFGFBBBFPFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_unk3000CNNFGFBBBFP_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> unk3000CNNFGFBBBFP_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3000CNNFGFBBBFP {
      get { return unk3000CNNFGFBBBFP_; }
    }

    /// <summary>Field number for the "lunch_box_data" field.</summary>
    public const int LunchBoxDataFieldNumber = 1;
    private global::Weedwacker.Shared.Network.Proto.LunchBoxData lunchBoxData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.LunchBoxData LunchBoxData {
      get { return lunchBoxData_; }
      set {
        lunchBoxData_ = value;
      }
    }

    /// <summary>Field number for the "cool_down_group_data_list" field.</summary>
    public const int CoolDownGroupDataListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.WidgetCoolDownData> _repeated_coolDownGroupDataList_codec
        = pb::FieldCodec.ForMessage(106, global::Weedwacker.Shared.Network.Proto.WidgetCoolDownData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.WidgetCoolDownData> coolDownGroupDataList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.WidgetCoolDownData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.WidgetCoolDownData> CoolDownGroupDataList {
      get { return coolDownGroupDataList_; }
    }

    /// <summary>Field number for the "anchor_point_list" field.</summary>
    public const int AnchorPointListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.AnchorPointData> _repeated_anchorPointList_codec
        = pb::FieldCodec.ForMessage(26, global::Weedwacker.Shared.Network.Proto.AnchorPointData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.AnchorPointData> anchorPointList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.AnchorPointData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.AnchorPointData> AnchorPointList {
      get { return anchorPointList_; }
    }

    /// <summary>Field number for the "slot_list" field.</summary>
    public const int SlotListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.WidgetSlotData> _repeated_slotList_codec
        = pb::FieldCodec.ForMessage(50, global::Weedwacker.Shared.Network.Proto.WidgetSlotData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.WidgetSlotData> slotList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.WidgetSlotData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.WidgetSlotData> SlotList {
      get { return slotList_; }
    }

    /// <summary>Field number for the "next_anchor_point_usable_time" field.</summary>
    public const int NextAnchorPointUsableTimeFieldNumber = 10;
    private uint nextAnchorPointUsableTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextAnchorPointUsableTime {
      get { return nextAnchorPointUsableTime_; }
      set {
        nextAnchorPointUsableTime_ = value;
      }
    }

    /// <summary>Field number for the "client_collector_data_list" field.</summary>
    public const int ClientCollectorDataListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ClientCollectorData> _repeated_clientCollectorDataList_codec
        = pb::FieldCodec.ForMessage(34, global::Weedwacker.Shared.Network.Proto.ClientCollectorData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ClientCollectorData> clientCollectorDataList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ClientCollectorData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ClientCollectorData> ClientCollectorDataList {
      get { return clientCollectorDataList_; }
    }

    /// <summary>Field number for the "oneof_gather_point_detector_data_list" field.</summary>
    public const int OneofGatherPointDetectorDataListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.OneofGatherPointDetectorData> _repeated_oneofGatherPointDetectorDataList_codec
        = pb::FieldCodec.ForMessage(122, global::Weedwacker.Shared.Network.Proto.OneofGatherPointDetectorData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.OneofGatherPointDetectorData> oneofGatherPointDetectorDataList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.OneofGatherPointDetectorData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.OneofGatherPointDetectorData> OneofGatherPointDetectorDataList {
      get { return oneofGatherPointDetectorDataList_; }
    }

    /// <summary>Field number for the "normal_cool_down_data_list" field.</summary>
    public const int NormalCoolDownDataListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.WidgetCoolDownData> _repeated_normalCoolDownDataList_codec
        = pb::FieldCodec.ForMessage(74, global::Weedwacker.Shared.Network.Proto.WidgetCoolDownData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.WidgetCoolDownData> normalCoolDownDataList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.WidgetCoolDownData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.WidgetCoolDownData> NormalCoolDownDataList {
      get { return normalCoolDownDataList_; }
    }

    /// <summary>Field number for the "Unk2700_COIELIGEACL" field.</summary>
    public const int Unk2700COIELIGEACLFieldNumber = 12;
    private global::Weedwacker.Shared.Network.Proto.Unk2700_CCEOEOHLAPK unk2700COIELIGEACL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Unk2700_CCEOEOHLAPK Unk2700COIELIGEACL {
      get { return unk2700COIELIGEACL_; }
      set {
        unk2700COIELIGEACL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AllWidgetDataNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AllWidgetDataNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk3000CNNFGFBBBFP_.Equals(other.unk3000CNNFGFBBBFP_)) return false;
      if (!object.Equals(LunchBoxData, other.LunchBoxData)) return false;
      if(!coolDownGroupDataList_.Equals(other.coolDownGroupDataList_)) return false;
      if(!anchorPointList_.Equals(other.anchorPointList_)) return false;
      if(!slotList_.Equals(other.slotList_)) return false;
      if (NextAnchorPointUsableTime != other.NextAnchorPointUsableTime) return false;
      if(!clientCollectorDataList_.Equals(other.clientCollectorDataList_)) return false;
      if(!oneofGatherPointDetectorDataList_.Equals(other.oneofGatherPointDetectorDataList_)) return false;
      if(!normalCoolDownDataList_.Equals(other.normalCoolDownDataList_)) return false;
      if (!object.Equals(Unk2700COIELIGEACL, other.Unk2700COIELIGEACL)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk3000CNNFGFBBBFP_.GetHashCode();
      if (lunchBoxData_ != null) hash ^= LunchBoxData.GetHashCode();
      hash ^= coolDownGroupDataList_.GetHashCode();
      hash ^= anchorPointList_.GetHashCode();
      hash ^= slotList_.GetHashCode();
      if (NextAnchorPointUsableTime != 0) hash ^= NextAnchorPointUsableTime.GetHashCode();
      hash ^= clientCollectorDataList_.GetHashCode();
      hash ^= oneofGatherPointDetectorDataList_.GetHashCode();
      hash ^= normalCoolDownDataList_.GetHashCode();
      if (unk2700COIELIGEACL_ != null) hash ^= Unk2700COIELIGEACL.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (lunchBoxData_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(LunchBoxData);
      }
      anchorPointList_.WriteTo(output, _repeated_anchorPointList_codec);
      clientCollectorDataList_.WriteTo(output, _repeated_clientCollectorDataList_codec);
      slotList_.WriteTo(output, _repeated_slotList_codec);
      normalCoolDownDataList_.WriteTo(output, _repeated_normalCoolDownDataList_codec);
      if (NextAnchorPointUsableTime != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(NextAnchorPointUsableTime);
      }
      unk3000CNNFGFBBBFP_.WriteTo(output, _repeated_unk3000CNNFGFBBBFP_codec);
      if (unk2700COIELIGEACL_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Unk2700COIELIGEACL);
      }
      coolDownGroupDataList_.WriteTo(output, _repeated_coolDownGroupDataList_codec);
      oneofGatherPointDetectorDataList_.WriteTo(output, _repeated_oneofGatherPointDetectorDataList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (lunchBoxData_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(LunchBoxData);
      }
      anchorPointList_.WriteTo(ref output, _repeated_anchorPointList_codec);
      clientCollectorDataList_.WriteTo(ref output, _repeated_clientCollectorDataList_codec);
      slotList_.WriteTo(ref output, _repeated_slotList_codec);
      normalCoolDownDataList_.WriteTo(ref output, _repeated_normalCoolDownDataList_codec);
      if (NextAnchorPointUsableTime != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(NextAnchorPointUsableTime);
      }
      unk3000CNNFGFBBBFP_.WriteTo(ref output, _repeated_unk3000CNNFGFBBBFP_codec);
      if (unk2700COIELIGEACL_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Unk2700COIELIGEACL);
      }
      coolDownGroupDataList_.WriteTo(ref output, _repeated_coolDownGroupDataList_codec);
      oneofGatherPointDetectorDataList_.WriteTo(ref output, _repeated_oneofGatherPointDetectorDataList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unk3000CNNFGFBBBFP_.CalculateSize(_repeated_unk3000CNNFGFBBBFP_codec);
      if (lunchBoxData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LunchBoxData);
      }
      size += coolDownGroupDataList_.CalculateSize(_repeated_coolDownGroupDataList_codec);
      size += anchorPointList_.CalculateSize(_repeated_anchorPointList_codec);
      size += slotList_.CalculateSize(_repeated_slotList_codec);
      if (NextAnchorPointUsableTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextAnchorPointUsableTime);
      }
      size += clientCollectorDataList_.CalculateSize(_repeated_clientCollectorDataList_codec);
      size += oneofGatherPointDetectorDataList_.CalculateSize(_repeated_oneofGatherPointDetectorDataList_codec);
      size += normalCoolDownDataList_.CalculateSize(_repeated_normalCoolDownDataList_codec);
      if (unk2700COIELIGEACL_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk2700COIELIGEACL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AllWidgetDataNotify other) {
      if (other == null) {
        return;
      }
      unk3000CNNFGFBBBFP_.Add(other.unk3000CNNFGFBBBFP_);
      if (other.lunchBoxData_ != null) {
        if (lunchBoxData_ == null) {
          LunchBoxData = new global::Weedwacker.Shared.Network.Proto.LunchBoxData();
        }
        LunchBoxData.MergeFrom(other.LunchBoxData);
      }
      coolDownGroupDataList_.Add(other.coolDownGroupDataList_);
      anchorPointList_.Add(other.anchorPointList_);
      slotList_.Add(other.slotList_);
      if (other.NextAnchorPointUsableTime != 0) {
        NextAnchorPointUsableTime = other.NextAnchorPointUsableTime;
      }
      clientCollectorDataList_.Add(other.clientCollectorDataList_);
      oneofGatherPointDetectorDataList_.Add(other.oneofGatherPointDetectorDataList_);
      normalCoolDownDataList_.Add(other.normalCoolDownDataList_);
      if (other.unk2700COIELIGEACL_ != null) {
        if (unk2700COIELIGEACL_ == null) {
          Unk2700COIELIGEACL = new global::Weedwacker.Shared.Network.Proto.Unk2700_CCEOEOHLAPK();
        }
        Unk2700COIELIGEACL.MergeFrom(other.Unk2700COIELIGEACL);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (lunchBoxData_ == null) {
              LunchBoxData = new global::Weedwacker.Shared.Network.Proto.LunchBoxData();
            }
            input.ReadMessage(LunchBoxData);
            break;
          }
          case 26: {
            anchorPointList_.AddEntriesFrom(input, _repeated_anchorPointList_codec);
            break;
          }
          case 34: {
            clientCollectorDataList_.AddEntriesFrom(input, _repeated_clientCollectorDataList_codec);
            break;
          }
          case 50: {
            slotList_.AddEntriesFrom(input, _repeated_slotList_codec);
            break;
          }
          case 74: {
            normalCoolDownDataList_.AddEntriesFrom(input, _repeated_normalCoolDownDataList_codec);
            break;
          }
          case 80: {
            NextAnchorPointUsableTime = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            unk3000CNNFGFBBBFP_.AddEntriesFrom(input, _repeated_unk3000CNNFGFBBBFP_codec);
            break;
          }
          case 98: {
            if (unk2700COIELIGEACL_ == null) {
              Unk2700COIELIGEACL = new global::Weedwacker.Shared.Network.Proto.Unk2700_CCEOEOHLAPK();
            }
            input.ReadMessage(Unk2700COIELIGEACL);
            break;
          }
          case 106: {
            coolDownGroupDataList_.AddEntriesFrom(input, _repeated_coolDownGroupDataList_codec);
            break;
          }
          case 122: {
            oneofGatherPointDetectorDataList_.AddEntriesFrom(input, _repeated_oneofGatherPointDetectorDataList_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (lunchBoxData_ == null) {
              LunchBoxData = new global::Weedwacker.Shared.Network.Proto.LunchBoxData();
            }
            input.ReadMessage(LunchBoxData);
            break;
          }
          case 26: {
            anchorPointList_.AddEntriesFrom(ref input, _repeated_anchorPointList_codec);
            break;
          }
          case 34: {
            clientCollectorDataList_.AddEntriesFrom(ref input, _repeated_clientCollectorDataList_codec);
            break;
          }
          case 50: {
            slotList_.AddEntriesFrom(ref input, _repeated_slotList_codec);
            break;
          }
          case 74: {
            normalCoolDownDataList_.AddEntriesFrom(ref input, _repeated_normalCoolDownDataList_codec);
            break;
          }
          case 80: {
            NextAnchorPointUsableTime = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            unk3000CNNFGFBBBFP_.AddEntriesFrom(ref input, _repeated_unk3000CNNFGFBBBFP_codec);
            break;
          }
          case 98: {
            if (unk2700COIELIGEACL_ == null) {
              Unk2700COIELIGEACL = new global::Weedwacker.Shared.Network.Proto.Unk2700_CCEOEOHLAPK();
            }
            input.ReadMessage(Unk2700COIELIGEACL);
            break;
          }
          case 106: {
            coolDownGroupDataList_.AddEntriesFrom(ref input, _repeated_coolDownGroupDataList_codec);
            break;
          }
          case 122: {
            oneofGatherPointDetectorDataList_.AddEntriesFrom(ref input, _repeated_oneofGatherPointDetectorDataList_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
