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

namespace Nebula.Common
{

  public partial class KeyValue : TBase
  {
    private byte[] _key;
    private byte[] _value;

    public byte[] Key
    {
      get
      {
        return _key;
      }
      set
      {
        __isset.key = true;
        this._key = value;
      }
    }

    public byte[] Value
    {
      get
      {
        return _value;
      }
      set
      {
        __isset.@value = true;
        this._value = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool key;
      public bool @value;
    }

    public KeyValue()
    {
    }

    public KeyValue DeepCopy()
    {
      var tmp165 = new KeyValue();
      if((Key != null) && __isset.key)
      {
        tmp165.Key = this.Key.ToArray();
      }
      tmp165.__isset.key = this.__isset.key;
      if((Value != null) && __isset.@value)
      {
        tmp165.Value = this.Value.ToArray();
      }
      tmp165.__isset.@value = this.__isset.@value;
      return tmp165;
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
              if (field.Type == TType.String)
              {
                Key = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Value = await iprot.ReadBinaryAsync(cancellationToken);
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
        var tmp166 = new TStruct("KeyValue");
        await oprot.WriteStructBeginAsync(tmp166, cancellationToken);
        var tmp167 = new TField();
        if((Key != null) && __isset.key)
        {
          tmp167.Name = "key";
          tmp167.Type = TType.String;
          tmp167.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp167, cancellationToken);
          await oprot.WriteBinaryAsync(Key, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Value != null) && __isset.@value)
        {
          tmp167.Name = "value";
          tmp167.Type = TType.String;
          tmp167.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp167, cancellationToken);
          await oprot.WriteBinaryAsync(Value, cancellationToken);
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
      if (!(that is KeyValue other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.key == other.__isset.key) && ((!__isset.key) || (TCollections.Equals(Key, other.Key))))
        && ((__isset.@value == other.__isset.@value) && ((!__isset.@value) || (TCollections.Equals(Value, other.Value))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Key != null) && __isset.key)
        {
          hashcode = (hashcode * 397) + Key.GetHashCode();
        }
        if((Value != null) && __isset.@value)
        {
          hashcode = (hashcode * 397) + Value.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp168 = new StringBuilder("KeyValue(");
      int tmp169 = 0;
      if((Key != null) && __isset.key)
      {
        if(0 < tmp169++) { tmp168.Append(", "); }
        tmp168.Append("Key: ");
        Key.ToString(tmp168);
      }
      if((Value != null) && __isset.@value)
      {
        if(0 < tmp169++) { tmp168.Append(", "); }
        tmp168.Append("Value: ");
        Value.ToString(tmp168);
      }
      tmp168.Append(')');
      return tmp168.ToString();
    }
  }

}
