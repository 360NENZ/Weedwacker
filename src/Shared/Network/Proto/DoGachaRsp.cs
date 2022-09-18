// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DoGachaRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from DoGachaRsp.proto</summary>
  public static partial class DoGachaRspReflection {

    #region Descriptor
    /// <summary>File descriptor for DoGachaRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DoGachaRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBEb0dhY2hhUnNwLnByb3RvGg9HYWNoYUl0ZW0ucHJvdG8iuwMKCkRvR2Fj",
            "aGFSc3ASHAoTVW5rMjcwMF9MRUVQRUxIRElORxibCyABKAgSGQoRZ2FjaGFf",
            "c2NoZWR1bGVfaWQYBSABKA0SFAoMd2lzaF9pdGVtX2lkGAggASgNEg8KB3Jl",
            "dGNvZGUYDSABKAUSFQoNY29zdF9pdGVtX251bRgKIAEoDRIZChFnYWNoYV90",
            "aW1lc19saW1pdBgBIAEoDRIUCgxjb3N0X2l0ZW1faWQYDiABKA0SEgoKZ2Fj",
            "aGFfdHlwZRgMIAEoDRIYChB0ZW5fY29zdF9pdGVtX2lkGAcgASgNEhkKEXdp",
            "c2hfbWF4X3Byb2dyZXNzGAkgASgNEhwKE1VuazI3MDBfT0pLS0hETEVEQ0kY",
            "2AkgASgNEhkKEXRlbl9jb3N0X2l0ZW1fbnVtGAMgASgNEhgKEGxlZnRfZ2Fj",
            "aGFfdGltZXMYBiABKA0SFQoNd2lzaF9wcm9ncmVzcxgCIAEoDRITCgtnYWNo",
            "YV90aW1lcxgEIAEoDRIjCg9nYWNoYV9pdGVtX2xpc3QYDyADKAsyCi5HYWNo",
            "YUl0ZW0SGAoQbmV3X2dhY2hhX3JhbmRvbRgLIAEoDUIiqgIfV2VlZHdhY2tl",
            "ci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GachaItemReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.DoGachaRsp), global::Weedwacker.Shared.Network.Proto.DoGachaRsp.Parser, new[]{ "Unk2700LEEPELHDING", "GachaScheduleId", "WishItemId", "Retcode", "CostItemNum", "GachaTimesLimit", "CostItemId", "GachaType", "TenCostItemId", "WishMaxProgress", "Unk2700OJKKHDLEDCI", "TenCostItemNum", "LeftGachaTimes", "WishProgress", "GachaTimes", "GachaItemList", "NewGachaRandom" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 1535
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class DoGachaRsp : pb::IMessage<DoGachaRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DoGachaRsp> _parser = new pb::MessageParser<DoGachaRsp>(() => new DoGachaRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DoGachaRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.DoGachaRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DoGachaRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DoGachaRsp(DoGachaRsp other) : this() {
      unk2700LEEPELHDING_ = other.unk2700LEEPELHDING_;
      gachaScheduleId_ = other.gachaScheduleId_;
      wishItemId_ = other.wishItemId_;
      retcode_ = other.retcode_;
      costItemNum_ = other.costItemNum_;
      gachaTimesLimit_ = other.gachaTimesLimit_;
      costItemId_ = other.costItemId_;
      gachaType_ = other.gachaType_;
      tenCostItemId_ = other.tenCostItemId_;
      wishMaxProgress_ = other.wishMaxProgress_;
      unk2700OJKKHDLEDCI_ = other.unk2700OJKKHDLEDCI_;
      tenCostItemNum_ = other.tenCostItemNum_;
      leftGachaTimes_ = other.leftGachaTimes_;
      wishProgress_ = other.wishProgress_;
      gachaTimes_ = other.gachaTimes_;
      gachaItemList_ = other.gachaItemList_.Clone();
      newGachaRandom_ = other.newGachaRandom_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DoGachaRsp Clone() {
      return new DoGachaRsp(this);
    }

    /// <summary>Field number for the "Unk2700_LEEPELHDING" field.</summary>
    public const int Unk2700LEEPELHDINGFieldNumber = 1435;
    private bool unk2700LEEPELHDING_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk2700LEEPELHDING {
      get { return unk2700LEEPELHDING_; }
      set {
        unk2700LEEPELHDING_ = value;
      }
    }

    /// <summary>Field number for the "gacha_schedule_id" field.</summary>
    public const int GachaScheduleIdFieldNumber = 5;
    private uint gachaScheduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GachaScheduleId {
      get { return gachaScheduleId_; }
      set {
        gachaScheduleId_ = value;
      }
    }

    /// <summary>Field number for the "wish_item_id" field.</summary>
    public const int WishItemIdFieldNumber = 8;
    private uint wishItemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WishItemId {
      get { return wishItemId_; }
      set {
        wishItemId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 13;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "cost_item_num" field.</summary>
    public const int CostItemNumFieldNumber = 10;
    private uint costItemNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CostItemNum {
      get { return costItemNum_; }
      set {
        costItemNum_ = value;
      }
    }

    /// <summary>Field number for the "gacha_times_limit" field.</summary>
    public const int GachaTimesLimitFieldNumber = 1;
    private uint gachaTimesLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GachaTimesLimit {
      get { return gachaTimesLimit_; }
      set {
        gachaTimesLimit_ = value;
      }
    }

    /// <summary>Field number for the "cost_item_id" field.</summary>
    public const int CostItemIdFieldNumber = 14;
    private uint costItemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CostItemId {
      get { return costItemId_; }
      set {
        costItemId_ = value;
      }
    }

    /// <summary>Field number for the "gacha_type" field.</summary>
    public const int GachaTypeFieldNumber = 12;
    private uint gachaType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GachaType {
      get { return gachaType_; }
      set {
        gachaType_ = value;
      }
    }

    /// <summary>Field number for the "ten_cost_item_id" field.</summary>
    public const int TenCostItemIdFieldNumber = 7;
    private uint tenCostItemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TenCostItemId {
      get { return tenCostItemId_; }
      set {
        tenCostItemId_ = value;
      }
    }

    /// <summary>Field number for the "wish_max_progress" field.</summary>
    public const int WishMaxProgressFieldNumber = 9;
    private uint wishMaxProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WishMaxProgress {
      get { return wishMaxProgress_; }
      set {
        wishMaxProgress_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_OJKKHDLEDCI" field.</summary>
    public const int Unk2700OJKKHDLEDCIFieldNumber = 1240;
    private uint unk2700OJKKHDLEDCI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700OJKKHDLEDCI {
      get { return unk2700OJKKHDLEDCI_; }
      set {
        unk2700OJKKHDLEDCI_ = value;
      }
    }

    /// <summary>Field number for the "ten_cost_item_num" field.</summary>
    public const int TenCostItemNumFieldNumber = 3;
    private uint tenCostItemNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TenCostItemNum {
      get { return tenCostItemNum_; }
      set {
        tenCostItemNum_ = value;
      }
    }

    /// <summary>Field number for the "left_gacha_times" field.</summary>
    public const int LeftGachaTimesFieldNumber = 6;
    private uint leftGachaTimes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LeftGachaTimes {
      get { return leftGachaTimes_; }
      set {
        leftGachaTimes_ = value;
      }
    }

    /// <summary>Field number for the "wish_progress" field.</summary>
    public const int WishProgressFieldNumber = 2;
    private uint wishProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WishProgress {
      get { return wishProgress_; }
      set {
        wishProgress_ = value;
      }
    }

    /// <summary>Field number for the "gacha_times" field.</summary>
    public const int GachaTimesFieldNumber = 4;
    private uint gachaTimes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GachaTimes {
      get { return gachaTimes_; }
      set {
        gachaTimes_ = value;
      }
    }

    /// <summary>Field number for the "gacha_item_list" field.</summary>
    public const int GachaItemListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GachaItem> _repeated_gachaItemList_codec
        = pb::FieldCodec.ForMessage(122, global::Weedwacker.Shared.Network.Proto.GachaItem.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GachaItem> gachaItemList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GachaItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GachaItem> GachaItemList {
      get { return gachaItemList_; }
    }

    /// <summary>Field number for the "new_gacha_random" field.</summary>
    public const int NewGachaRandomFieldNumber = 11;
    private uint newGachaRandom_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NewGachaRandom {
      get { return newGachaRandom_; }
      set {
        newGachaRandom_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DoGachaRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DoGachaRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk2700LEEPELHDING != other.Unk2700LEEPELHDING) return false;
      if (GachaScheduleId != other.GachaScheduleId) return false;
      if (WishItemId != other.WishItemId) return false;
      if (Retcode != other.Retcode) return false;
      if (CostItemNum != other.CostItemNum) return false;
      if (GachaTimesLimit != other.GachaTimesLimit) return false;
      if (CostItemId != other.CostItemId) return false;
      if (GachaType != other.GachaType) return false;
      if (TenCostItemId != other.TenCostItemId) return false;
      if (WishMaxProgress != other.WishMaxProgress) return false;
      if (Unk2700OJKKHDLEDCI != other.Unk2700OJKKHDLEDCI) return false;
      if (TenCostItemNum != other.TenCostItemNum) return false;
      if (LeftGachaTimes != other.LeftGachaTimes) return false;
      if (WishProgress != other.WishProgress) return false;
      if (GachaTimes != other.GachaTimes) return false;
      if(!gachaItemList_.Equals(other.gachaItemList_)) return false;
      if (NewGachaRandom != other.NewGachaRandom) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk2700LEEPELHDING != false) hash ^= Unk2700LEEPELHDING.GetHashCode();
      if (GachaScheduleId != 0) hash ^= GachaScheduleId.GetHashCode();
      if (WishItemId != 0) hash ^= WishItemId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (CostItemNum != 0) hash ^= CostItemNum.GetHashCode();
      if (GachaTimesLimit != 0) hash ^= GachaTimesLimit.GetHashCode();
      if (CostItemId != 0) hash ^= CostItemId.GetHashCode();
      if (GachaType != 0) hash ^= GachaType.GetHashCode();
      if (TenCostItemId != 0) hash ^= TenCostItemId.GetHashCode();
      if (WishMaxProgress != 0) hash ^= WishMaxProgress.GetHashCode();
      if (Unk2700OJKKHDLEDCI != 0) hash ^= Unk2700OJKKHDLEDCI.GetHashCode();
      if (TenCostItemNum != 0) hash ^= TenCostItemNum.GetHashCode();
      if (LeftGachaTimes != 0) hash ^= LeftGachaTimes.GetHashCode();
      if (WishProgress != 0) hash ^= WishProgress.GetHashCode();
      if (GachaTimes != 0) hash ^= GachaTimes.GetHashCode();
      hash ^= gachaItemList_.GetHashCode();
      if (NewGachaRandom != 0) hash ^= NewGachaRandom.GetHashCode();
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
      if (GachaTimesLimit != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GachaTimesLimit);
      }
      if (WishProgress != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(WishProgress);
      }
      if (TenCostItemNum != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TenCostItemNum);
      }
      if (GachaTimes != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GachaTimes);
      }
      if (GachaScheduleId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GachaScheduleId);
      }
      if (LeftGachaTimes != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(LeftGachaTimes);
      }
      if (TenCostItemId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(TenCostItemId);
      }
      if (WishItemId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(WishItemId);
      }
      if (WishMaxProgress != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(WishMaxProgress);
      }
      if (CostItemNum != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CostItemNum);
      }
      if (NewGachaRandom != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(NewGachaRandom);
      }
      if (GachaType != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(GachaType);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(Retcode);
      }
      if (CostItemId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(CostItemId);
      }
      gachaItemList_.WriteTo(output, _repeated_gachaItemList_codec);
      if (Unk2700OJKKHDLEDCI != 0) {
        output.WriteRawTag(192, 77);
        output.WriteUInt32(Unk2700OJKKHDLEDCI);
      }
      if (Unk2700LEEPELHDING != false) {
        output.WriteRawTag(216, 89);
        output.WriteBool(Unk2700LEEPELHDING);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (GachaTimesLimit != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GachaTimesLimit);
      }
      if (WishProgress != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(WishProgress);
      }
      if (TenCostItemNum != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TenCostItemNum);
      }
      if (GachaTimes != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GachaTimes);
      }
      if (GachaScheduleId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GachaScheduleId);
      }
      if (LeftGachaTimes != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(LeftGachaTimes);
      }
      if (TenCostItemId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(TenCostItemId);
      }
      if (WishItemId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(WishItemId);
      }
      if (WishMaxProgress != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(WishMaxProgress);
      }
      if (CostItemNum != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CostItemNum);
      }
      if (NewGachaRandom != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(NewGachaRandom);
      }
      if (GachaType != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(GachaType);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(Retcode);
      }
      if (CostItemId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(CostItemId);
      }
      gachaItemList_.WriteTo(ref output, _repeated_gachaItemList_codec);
      if (Unk2700OJKKHDLEDCI != 0) {
        output.WriteRawTag(192, 77);
        output.WriteUInt32(Unk2700OJKKHDLEDCI);
      }
      if (Unk2700LEEPELHDING != false) {
        output.WriteRawTag(216, 89);
        output.WriteBool(Unk2700LEEPELHDING);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Unk2700LEEPELHDING != false) {
        size += 2 + 1;
      }
      if (GachaScheduleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GachaScheduleId);
      }
      if (WishItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WishItemId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (CostItemNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CostItemNum);
      }
      if (GachaTimesLimit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GachaTimesLimit);
      }
      if (CostItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CostItemId);
      }
      if (GachaType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GachaType);
      }
      if (TenCostItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TenCostItemId);
      }
      if (WishMaxProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WishMaxProgress);
      }
      if (Unk2700OJKKHDLEDCI != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700OJKKHDLEDCI);
      }
      if (TenCostItemNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TenCostItemNum);
      }
      if (LeftGachaTimes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LeftGachaTimes);
      }
      if (WishProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WishProgress);
      }
      if (GachaTimes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GachaTimes);
      }
      size += gachaItemList_.CalculateSize(_repeated_gachaItemList_codec);
      if (NewGachaRandom != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NewGachaRandom);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DoGachaRsp other) {
      if (other == null) {
        return;
      }
      if (other.Unk2700LEEPELHDING != false) {
        Unk2700LEEPELHDING = other.Unk2700LEEPELHDING;
      }
      if (other.GachaScheduleId != 0) {
        GachaScheduleId = other.GachaScheduleId;
      }
      if (other.WishItemId != 0) {
        WishItemId = other.WishItemId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.CostItemNum != 0) {
        CostItemNum = other.CostItemNum;
      }
      if (other.GachaTimesLimit != 0) {
        GachaTimesLimit = other.GachaTimesLimit;
      }
      if (other.CostItemId != 0) {
        CostItemId = other.CostItemId;
      }
      if (other.GachaType != 0) {
        GachaType = other.GachaType;
      }
      if (other.TenCostItemId != 0) {
        TenCostItemId = other.TenCostItemId;
      }
      if (other.WishMaxProgress != 0) {
        WishMaxProgress = other.WishMaxProgress;
      }
      if (other.Unk2700OJKKHDLEDCI != 0) {
        Unk2700OJKKHDLEDCI = other.Unk2700OJKKHDLEDCI;
      }
      if (other.TenCostItemNum != 0) {
        TenCostItemNum = other.TenCostItemNum;
      }
      if (other.LeftGachaTimes != 0) {
        LeftGachaTimes = other.LeftGachaTimes;
      }
      if (other.WishProgress != 0) {
        WishProgress = other.WishProgress;
      }
      if (other.GachaTimes != 0) {
        GachaTimes = other.GachaTimes;
      }
      gachaItemList_.Add(other.gachaItemList_);
      if (other.NewGachaRandom != 0) {
        NewGachaRandom = other.NewGachaRandom;
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
          case 8: {
            GachaTimesLimit = input.ReadUInt32();
            break;
          }
          case 16: {
            WishProgress = input.ReadUInt32();
            break;
          }
          case 24: {
            TenCostItemNum = input.ReadUInt32();
            break;
          }
          case 32: {
            GachaTimes = input.ReadUInt32();
            break;
          }
          case 40: {
            GachaScheduleId = input.ReadUInt32();
            break;
          }
          case 48: {
            LeftGachaTimes = input.ReadUInt32();
            break;
          }
          case 56: {
            TenCostItemId = input.ReadUInt32();
            break;
          }
          case 64: {
            WishItemId = input.ReadUInt32();
            break;
          }
          case 72: {
            WishMaxProgress = input.ReadUInt32();
            break;
          }
          case 80: {
            CostItemNum = input.ReadUInt32();
            break;
          }
          case 88: {
            NewGachaRandom = input.ReadUInt32();
            break;
          }
          case 96: {
            GachaType = input.ReadUInt32();
            break;
          }
          case 104: {
            Retcode = input.ReadInt32();
            break;
          }
          case 112: {
            CostItemId = input.ReadUInt32();
            break;
          }
          case 122: {
            gachaItemList_.AddEntriesFrom(input, _repeated_gachaItemList_codec);
            break;
          }
          case 9920: {
            Unk2700OJKKHDLEDCI = input.ReadUInt32();
            break;
          }
          case 11480: {
            Unk2700LEEPELHDING = input.ReadBool();
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
          case 8: {
            GachaTimesLimit = input.ReadUInt32();
            break;
          }
          case 16: {
            WishProgress = input.ReadUInt32();
            break;
          }
          case 24: {
            TenCostItemNum = input.ReadUInt32();
            break;
          }
          case 32: {
            GachaTimes = input.ReadUInt32();
            break;
          }
          case 40: {
            GachaScheduleId = input.ReadUInt32();
            break;
          }
          case 48: {
            LeftGachaTimes = input.ReadUInt32();
            break;
          }
          case 56: {
            TenCostItemId = input.ReadUInt32();
            break;
          }
          case 64: {
            WishItemId = input.ReadUInt32();
            break;
          }
          case 72: {
            WishMaxProgress = input.ReadUInt32();
            break;
          }
          case 80: {
            CostItemNum = input.ReadUInt32();
            break;
          }
          case 88: {
            NewGachaRandom = input.ReadUInt32();
            break;
          }
          case 96: {
            GachaType = input.ReadUInt32();
            break;
          }
          case 104: {
            Retcode = input.ReadInt32();
            break;
          }
          case 112: {
            CostItemId = input.ReadUInt32();
            break;
          }
          case 122: {
            gachaItemList_.AddEntriesFrom(ref input, _repeated_gachaItemList_codec);
            break;
          }
          case 9920: {
            Unk2700OJKKHDLEDCI = input.ReadUInt32();
            break;
          }
          case 11480: {
            Unk2700LEEPELHDING = input.ReadBool();
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