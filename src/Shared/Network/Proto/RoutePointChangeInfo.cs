// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RoutePointChangeInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from RoutePointChangeInfo.proto</summary>
  public static partial class RoutePointChangeInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RoutePointChangeInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoutePointChangeInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpSb3V0ZVBvaW50Q2hhbmdlSW5mby5wcm90byJXChRSb3V0ZVBvaW50Q2hh",
            "bmdlSW5mbxIRCgl3YWl0X3RpbWUYBiABKAISFwoPdGFyZ2V0X3ZlbG9jaXR5",
            "GA4gASgCEhMKC3BvaW50X2luZGV4GAsgASgNQiKqAh9XZWVkd2Fja2VyLlNo",
            "YXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.RoutePointChangeInfo), global::Weedwacker.Shared.Network.Proto.RoutePointChangeInfo.Parser, new[]{ "WaitTime", "TargetVelocity", "PointIndex" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RoutePointChangeInfo : pb::IMessage<RoutePointChangeInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RoutePointChangeInfo> _parser = new pb::MessageParser<RoutePointChangeInfo>(() => new RoutePointChangeInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RoutePointChangeInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.RoutePointChangeInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RoutePointChangeInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RoutePointChangeInfo(RoutePointChangeInfo other) : this() {
      waitTime_ = other.waitTime_;
      targetVelocity_ = other.targetVelocity_;
      pointIndex_ = other.pointIndex_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RoutePointChangeInfo Clone() {
      return new RoutePointChangeInfo(this);
    }

    /// <summary>Field number for the "wait_time" field.</summary>
    public const int WaitTimeFieldNumber = 6;
    private float waitTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float WaitTime {
      get { return waitTime_; }
      set {
        waitTime_ = value;
      }
    }

    /// <summary>Field number for the "target_velocity" field.</summary>
    public const int TargetVelocityFieldNumber = 14;
    private float targetVelocity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float TargetVelocity {
      get { return targetVelocity_; }
      set {
        targetVelocity_ = value;
      }
    }

    /// <summary>Field number for the "point_index" field.</summary>
    public const int PointIndexFieldNumber = 11;
    private uint pointIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PointIndex {
      get { return pointIndex_; }
      set {
        pointIndex_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RoutePointChangeInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RoutePointChangeInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(WaitTime, other.WaitTime)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TargetVelocity, other.TargetVelocity)) return false;
      if (PointIndex != other.PointIndex) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (WaitTime != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(WaitTime);
      if (TargetVelocity != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TargetVelocity);
      if (PointIndex != 0) hash ^= PointIndex.GetHashCode();
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
      if (WaitTime != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(WaitTime);
      }
      if (PointIndex != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(PointIndex);
      }
      if (TargetVelocity != 0F) {
        output.WriteRawTag(117);
        output.WriteFloat(TargetVelocity);
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
      if (WaitTime != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(WaitTime);
      }
      if (PointIndex != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(PointIndex);
      }
      if (TargetVelocity != 0F) {
        output.WriteRawTag(117);
        output.WriteFloat(TargetVelocity);
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
      if (WaitTime != 0F) {
        size += 1 + 4;
      }
      if (TargetVelocity != 0F) {
        size += 1 + 4;
      }
      if (PointIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PointIndex);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RoutePointChangeInfo other) {
      if (other == null) {
        return;
      }
      if (other.WaitTime != 0F) {
        WaitTime = other.WaitTime;
      }
      if (other.TargetVelocity != 0F) {
        TargetVelocity = other.TargetVelocity;
      }
      if (other.PointIndex != 0) {
        PointIndex = other.PointIndex;
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
          case 53: {
            WaitTime = input.ReadFloat();
            break;
          }
          case 88: {
            PointIndex = input.ReadUInt32();
            break;
          }
          case 117: {
            TargetVelocity = input.ReadFloat();
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
          case 53: {
            WaitTime = input.ReadFloat();
            break;
          }
          case 88: {
            PointIndex = input.ReadUInt32();
            break;
          }
          case 117: {
            TargetVelocity = input.ReadFloat();
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
