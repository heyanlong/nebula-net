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

namespace Nebula.Storage
{

  public partial class EdgeProp : TBase
  {
    private int _type;
    private List<byte[]> _props;

    public int Type
    {
      get
      {
        return _type;
      }
      set
      {
        __isset.type = true;
        this._type = value;
      }
    }

    public List<byte[]> Props
    {
      get
      {
        return _props;
      }
      set
      {
        __isset.props = true;
        this._props = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool type;
      public bool props;
    }

    public EdgeProp()
    {
    }

    public EdgeProp DeepCopy()
    {
      var tmp34 = new EdgeProp();
      if(__isset.type)
      {
        tmp34.Type = this.Type;
      }
      tmp34.__isset.type = this.__isset.type;
      if((Props != null) && __isset.props)
      {
        tmp34.Props = this.Props.DeepCopy();
      }
      tmp34.__isset.props = this.__isset.props;
      return tmp34;
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
                Type = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.List)
              {
                {
                  TList _list35 = await iprot.ReadListBeginAsync(cancellationToken);
                  Props = new List<byte[]>(_list35.Count);
                  for(int _i36 = 0; _i36 < _list35.Count; ++_i36)
                  {
                    byte[] _elem37;
                    _elem37 = await iprot.ReadBinaryAsync(cancellationToken);
                    Props.Add(_elem37);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
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
        var tmp38 = new TStruct("EdgeProp");
        await oprot.WriteStructBeginAsync(tmp38, cancellationToken);
        var tmp39 = new TField();
        if(__isset.type)
        {
          tmp39.Name = "type";
          tmp39.Type = TType.I32;
          tmp39.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp39, cancellationToken);
          await oprot.WriteI32Async(Type, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Props != null) && __isset.props)
        {
          tmp39.Name = "props";
          tmp39.Type = TType.List;
          tmp39.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp39, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.String, Props.Count), cancellationToken);
            foreach (byte[] _iter40 in Props)
            {
              await oprot.WriteBinaryAsync(_iter40, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
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
      if (!(that is EdgeProp other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.type == other.__isset.type) && ((!__isset.type) || (System.Object.Equals(Type, other.Type))))
        && ((__isset.props == other.__isset.props) && ((!__isset.props) || (TCollections.Equals(Props, other.Props))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.type)
        {
          hashcode = (hashcode * 397) + Type.GetHashCode();
        }
        if((Props != null) && __isset.props)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Props);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp41 = new StringBuilder("EdgeProp(");
      int tmp42 = 0;
      if(__isset.type)
      {
        if(0 < tmp42++) { tmp41.Append(", "); }
        tmp41.Append("Type: ");
        Type.ToString(tmp41);
      }
      if((Props != null) && __isset.props)
      {
        if(0 < tmp42++) { tmp41.Append(", "); }
        tmp41.Append("Props: ");
        Props.ToString(tmp41);
      }
      tmp41.Append(')');
      return tmp41.ToString();
    }
  }

}
