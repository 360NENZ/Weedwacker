// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk3000_AMGHKNBNNPD.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk3000_AMGHKNBNNPD.proto</summary>
  public static partial class Unk3000AMGHKNBNNPDReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk3000_AMGHKNBNNPD.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk3000AMGHKNBNNPDReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmszMDAwX0FNR0hLTkJOTlBELnByb3RvGgxWZWN0b3IucHJvdG8ikAIK",
            "E1VuazMwMDBfQU1HSEtOQk5OUEQSGwoTVW5rMzAwMF9PRkZCQkhJS0RJThgB",
            "IAEoAhIeChZhbmltYXRvcl9zdGF0ZV9pZF9saXN0GAIgAygNEhEKCWVudGl0",
            "eV9pZBgDIAEoDRIaChJuZWVkX3NldF9pc19pbl9haXIYDSABKAgSDQoFc3Bl",
            "ZWQYDCABKAISGwoTVW5rMzAwMF9QSlBGSVBPTE5BSBgIIAEoAhIpCiFjaGVj",
            "a19hbmltYXRvcl9zdGF0ZV9vbl9leGl0X29ubHkYCyABKAgSGQoRb3ZlcnJp",
            "ZGVfY29sbGlkZXIYDiABKAkSGwoKdGFyZ2V0X3BvcxgKIAEoCzIHLlZlY3Rv",
            "ckIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk3000_AMGHKNBNNPD), global::Weedwacker.Shared.Network.Proto.Unk3000_AMGHKNBNNPD.Parser, new[]{ "Unk3000OFFBBHIKDIN", "AnimatorStateIdList", "EntityId", "NeedSetIsInAir", "Speed", "Unk3000PJPFIPOLNAH", "CheckAnimatorStateOnExitOnly", "OverrideCollider", "TargetPos" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Unk3000_AMGHKNBNNPD : pb::IMessage<Unk3000_AMGHKNBNNPD>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk3000_AMGHKNBNNPD> _parser = new pb::MessageParser<Unk3000_AMGHKNBNNPD>(() => new Unk3000_AMGHKNBNNPD());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk3000_AMGHKNBNNPD> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk3000AMGHKNBNNPDReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_AMGHKNBNNPD() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_AMGHKNBNNPD(Unk3000_AMGHKNBNNPD other) : this() {
      unk3000OFFBBHIKDIN_ = other.unk3000OFFBBHIKDIN_;
      animatorStateIdList_ = other.animatorStateIdList_.Clone();
      entityId_ = other.entityId_;
      needSetIsInAir_ = other.needSetIsInAir_;
      speed_ = other.speed_;
      unk3000PJPFIPOLNAH_ = other.unk3000PJPFIPOLNAH_;
      checkAnimatorStateOnExitOnly_ = other.checkAnimatorStateOnExitOnly_;
      overrideCollider_ = other.overrideCollider_;
      targetPos_ = other.targetPos_ != null ? other.targetPos_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_AMGHKNBNNPD Clone() {
      return new Unk3000_AMGHKNBNNPD(this);
    }

    /// <summary>Field number for the "Unk3000_OFFBBHIKDIN" field.</summary>
    public const int Unk3000OFFBBHIKDINFieldNumber = 1;
    private float unk3000OFFBBHIKDIN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Unk3000OFFBBHIKDIN {
      get { return unk3000OFFBBHIKDIN_; }
      set {
        unk3000OFFBBHIKDIN_ = value;
      }
    }

    /// <summary>Field number for the "animator_state_id_list" field.</summary>
    public const int AnimatorStateIdListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_animatorStateIdList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> animatorStateIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AnimatorStateIdList {
      get { return animatorStateIdList_; }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 3;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "need_set_is_in_air" field.</summary>
    public const int NeedSetIsInAirFieldNumber = 13;
    private bool needSetIsInAir_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool NeedSetIsInAir {
      get { return needSetIsInAir_; }
      set {
        needSetIsInAir_ = value;
      }
    }

    /// <summary>Field number for the "speed" field.</summary>
    public const int SpeedFieldNumber = 12;
    private float speed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Speed {
      get { return speed_; }
      set {
        speed_ = value;
      }
    }

    /// <summary>Field number for the "Unk3000_PJPFIPOLNAH" field.</summary>
    public const int Unk3000PJPFIPOLNAHFieldNumber = 8;
    private float unk3000PJPFIPOLNAH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Unk3000PJPFIPOLNAH {
      get { return unk3000PJPFIPOLNAH_; }
      set {
        unk3000PJPFIPOLNAH_ = value;
      }
    }

    /// <summary>Field number for the "check_animator_state_on_exit_only" field.</summary>
    public const int CheckAnimatorStateOnExitOnlyFieldNumber = 11;
    private bool checkAnimatorStateOnExitOnly_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CheckAnimatorStateOnExitOnly {
      get { return checkAnimatorStateOnExitOnly_; }
      set {
        checkAnimatorStateOnExitOnly_ = value;
      }
    }

    /// <summary>Field number for the "override_collider" field.</summary>
    public const int OverrideColliderFieldNumber = 14;
    private string overrideCollider_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OverrideCollider {
      get { return overrideCollider_; }
      set {
        overrideCollider_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "target_pos" field.</summary>
    public const int TargetPosFieldNumber = 10;
    private global::Weedwacker.Shared.Network.Proto.Vector targetPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector TargetPos {
      get { return targetPos_; }
      set {
        targetPos_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk3000_AMGHKNBNNPD);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk3000_AMGHKNBNNPD other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Unk3000OFFBBHIKDIN, other.Unk3000OFFBBHIKDIN)) return false;
      if(!animatorStateIdList_.Equals(other.animatorStateIdList_)) return false;
      if (EntityId != other.EntityId) return false;
      if (NeedSetIsInAir != other.NeedSetIsInAir) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Speed, other.Speed)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Unk3000PJPFIPOLNAH, other.Unk3000PJPFIPOLNAH)) return false;
      if (CheckAnimatorStateOnExitOnly != other.CheckAnimatorStateOnExitOnly) return false;
      if (OverrideCollider != other.OverrideCollider) return false;
      if (!object.Equals(TargetPos, other.TargetPos)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3000OFFBBHIKDIN != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Unk3000OFFBBHIKDIN);
      hash ^= animatorStateIdList_.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (NeedSetIsInAir != false) hash ^= NeedSetIsInAir.GetHashCode();
      if (Speed != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Speed);
      if (Unk3000PJPFIPOLNAH != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Unk3000PJPFIPOLNAH);
      if (CheckAnimatorStateOnExitOnly != false) hash ^= CheckAnimatorStateOnExitOnly.GetHashCode();
      if (OverrideCollider.Length != 0) hash ^= OverrideCollider.GetHashCode();
      if (targetPos_ != null) hash ^= TargetPos.GetHashCode();
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
      if (Unk3000OFFBBHIKDIN != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(Unk3000OFFBBHIKDIN);
      }
      animatorStateIdList_.WriteTo(output, _repeated_animatorStateIdList_codec);
      if (EntityId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(EntityId);
      }
      if (Unk3000PJPFIPOLNAH != 0F) {
        output.WriteRawTag(69);
        output.WriteFloat(Unk3000PJPFIPOLNAH);
      }
      if (targetPos_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(TargetPos);
      }
      if (CheckAnimatorStateOnExitOnly != false) {
        output.WriteRawTag(88);
        output.WriteBool(CheckAnimatorStateOnExitOnly);
      }
      if (Speed != 0F) {
        output.WriteRawTag(101);
        output.WriteFloat(Speed);
      }
      if (NeedSetIsInAir != false) {
        output.WriteRawTag(104);
        output.WriteBool(NeedSetIsInAir);
      }
      if (OverrideCollider.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(OverrideCollider);
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
      if (Unk3000OFFBBHIKDIN != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(Unk3000OFFBBHIKDIN);
      }
      animatorStateIdList_.WriteTo(ref output, _repeated_animatorStateIdList_codec);
      if (EntityId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(EntityId);
      }
      if (Unk3000PJPFIPOLNAH != 0F) {
        output.WriteRawTag(69);
        output.WriteFloat(Unk3000PJPFIPOLNAH);
      }
      if (targetPos_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(TargetPos);
      }
      if (CheckAnimatorStateOnExitOnly != false) {
        output.WriteRawTag(88);
        output.WriteBool(CheckAnimatorStateOnExitOnly);
      }
      if (Speed != 0F) {
        output.WriteRawTag(101);
        output.WriteFloat(Speed);
      }
      if (NeedSetIsInAir != false) {
        output.WriteRawTag(104);
        output.WriteBool(NeedSetIsInAir);
      }
      if (OverrideCollider.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(OverrideCollider);
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
      if (Unk3000OFFBBHIKDIN != 0F) {
        size += 1 + 4;
      }
      size += animatorStateIdList_.CalculateSize(_repeated_animatorStateIdList_codec);
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (NeedSetIsInAir != false) {
        size += 1 + 1;
      }
      if (Speed != 0F) {
        size += 1 + 4;
      }
      if (Unk3000PJPFIPOLNAH != 0F) {
        size += 1 + 4;
      }
      if (CheckAnimatorStateOnExitOnly != false) {
        size += 1 + 1;
      }
      if (OverrideCollider.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OverrideCollider);
      }
      if (targetPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetPos);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk3000_AMGHKNBNNPD other) {
      if (other == null) {
        return;
      }
      if (other.Unk3000OFFBBHIKDIN != 0F) {
        Unk3000OFFBBHIKDIN = other.Unk3000OFFBBHIKDIN;
      }
      animatorStateIdList_.Add(other.animatorStateIdList_);
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.NeedSetIsInAir != false) {
        NeedSetIsInAir = other.NeedSetIsInAir;
      }
      if (other.Speed != 0F) {
        Speed = other.Speed;
      }
      if (other.Unk3000PJPFIPOLNAH != 0F) {
        Unk3000PJPFIPOLNAH = other.Unk3000PJPFIPOLNAH;
      }
      if (other.CheckAnimatorStateOnExitOnly != false) {
        CheckAnimatorStateOnExitOnly = other.CheckAnimatorStateOnExitOnly;
      }
      if (other.OverrideCollider.Length != 0) {
        OverrideCollider = other.OverrideCollider;
      }
      if (other.targetPos_ != null) {
        if (targetPos_ == null) {
          TargetPos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        TargetPos.MergeFrom(other.TargetPos);
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
          case 13: {
            Unk3000OFFBBHIKDIN = input.ReadFloat();
            break;
          }
          case 18:
          case 16: {
            animatorStateIdList_.AddEntriesFrom(input, _repeated_animatorStateIdList_codec);
            break;
          }
          case 24: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 69: {
            Unk3000PJPFIPOLNAH = input.ReadFloat();
            break;
          }
          case 82: {
            if (targetPos_ == null) {
              TargetPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(TargetPos);
            break;
          }
          case 88: {
            CheckAnimatorStateOnExitOnly = input.ReadBool();
            break;
          }
          case 101: {
            Speed = input.ReadFloat();
            break;
          }
          case 104: {
            NeedSetIsInAir = input.ReadBool();
            break;
          }
          case 114: {
            OverrideCollider = input.ReadString();
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
          case 13: {
            Unk3000OFFBBHIKDIN = input.ReadFloat();
            break;
          }
          case 18:
          case 16: {
            animatorStateIdList_.AddEntriesFrom(ref input, _repeated_animatorStateIdList_codec);
            break;
          }
          case 24: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 69: {
            Unk3000PJPFIPOLNAH = input.ReadFloat();
            break;
          }
          case 82: {
            if (targetPos_ == null) {
              TargetPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(TargetPos);
            break;
          }
          case 88: {
            CheckAnimatorStateOnExitOnly = input.ReadBool();
            break;
          }
          case 101: {
            Speed = input.ReadFloat();
            break;
          }
          case 104: {
            NeedSetIsInAir = input.ReadBool();
            break;
          }
          case 114: {
            OverrideCollider = input.ReadString();
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
