/**
 * Autogenerated by Thrift Compiler (0.15.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Nebula.Meta
{

  public partial class DropTagReq : TBase
  {
    private int _space_id;
    private byte[] _tag_name;
    private bool _if_exists;

    public int Space_id
    {
      get
      {
        return _space_id;
      }
      set
      {
        __isset.space_id = true;
        this._space_id = value;
      }
    }

    public byte[] Tag_name
    {
      get
      {
        return _tag_name;
      }
      set
      {
        __isset.tag_name = true;
        this._tag_name = value;
      }
    }

    public bool If_exists
    {
      get
      {
        return _if_exists;
      }
      set
      {
        __isset.if_exists = true;
        this._if_exists = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool space_id;
      public bool tag_name;
      public bool if_exists;
    }

    public DropTagReq()
    {
    }

    public DropTagReq DeepCopy()
    {
      var tmp237 = new DropTagReq();
      if(__isset.space_id)
      {
        tmp237.Space_id = this.Space_id;
      }
      tmp237.__isset.space_id = this.__isset.space_id;
      if((Tag_name != null) && __isset.tag_name)
      {
        tmp237.Tag_name = this.Tag_name.ToArray();
      }
      tmp237.__isset.tag_name = this.__isset.tag_name;
      if(__isset.if_exists)
      {
        tmp237.If_exists = this.If_exists;
      }
      tmp237.__isset.if_exists = this.__isset.if_exists;
      return tmp237;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I32)
              {
                Space_id = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Tag_name = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Bool)
              {
                If_exists = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp238 = new TStruct("DropTagReq");
        await oprot.WriteStructBeginAsync(tmp238, cancellationToken);
        var tmp239 = new TField();
        if(__isset.space_id)
        {
          tmp239.Name = "space_id";
          tmp239.Type = TType.I32;
          tmp239.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp239, cancellationToken);
          await oprot.WriteI32Async(Space_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Tag_name != null) && __isset.tag_name)
        {
          tmp239.Name = "tag_name";
          tmp239.Type = TType.String;
          tmp239.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp239, cancellationToken);
          await oprot.WriteBinaryAsync(Tag_name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.if_exists)
        {
          tmp239.Name = "if_exists";
          tmp239.Type = TType.Bool;
          tmp239.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp239, cancellationToken);
          await oprot.WriteBoolAsync(If_exists, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is DropTagReq other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.space_id == other.__isset.space_id) && ((!__isset.space_id) || (System.Object.Equals(Space_id, other.Space_id))))
        && ((__isset.tag_name == other.__isset.tag_name) && ((!__isset.tag_name) || (TCollections.Equals(Tag_name, other.Tag_name))))
        && ((__isset.if_exists == other.__isset.if_exists) && ((!__isset.if_exists) || (System.Object.Equals(If_exists, other.If_exists))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.space_id)
        {
          hashcode = (hashcode * 397) + Space_id.GetHashCode();
        }
        if((Tag_name != null) && __isset.tag_name)
        {
          hashcode = (hashcode * 397) + Tag_name.GetHashCode();
        }
        if(__isset.if_exists)
        {
          hashcode = (hashcode * 397) + If_exists.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp240 = new StringBuilder("DropTagReq(");
      int tmp241 = 0;
      if(__isset.space_id)
      {
        if(0 < tmp241++) { tmp240.Append(", "); }
        tmp240.Append("Space_id: ");
        Space_id.ToString(tmp240);
      }
      if((Tag_name != null) && __isset.tag_name)
      {
        if(0 < tmp241++) { tmp240.Append(", "); }
        tmp240.Append("Tag_name: ");
        Tag_name.ToString(tmp240);
      }
      if(__isset.if_exists)
      {
        if(0 < tmp241++) { tmp240.Append(", "); }
        tmp240.Append("If_exists: ");
        If_exists.ToString(tmp240);
      }
      tmp240.Append(')');
      return tmp240.ToString();
    }
  }

}
