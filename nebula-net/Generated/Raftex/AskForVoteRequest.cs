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

namespace Nebula.Raftex
{

  public partial class AskForVoteRequest : TBase
  {
    private int _space;
    private int _part;
    private string _candidate_addr;
    private int _candidate_port;
    private long _term;
    private long _last_log_id;
    private long _last_log_term;

    public int Space
    {
      get
      {
        return _space;
      }
      set
      {
        __isset.space = true;
        this._space = value;
      }
    }

    public int Part
    {
      get
      {
        return _part;
      }
      set
      {
        __isset.part = true;
        this._part = value;
      }
    }

    public string Candidate_addr
    {
      get
      {
        return _candidate_addr;
      }
      set
      {
        __isset.candidate_addr = true;
        this._candidate_addr = value;
      }
    }

    public int Candidate_port
    {
      get
      {
        return _candidate_port;
      }
      set
      {
        __isset.candidate_port = true;
        this._candidate_port = value;
      }
    }

    public long Term
    {
      get
      {
        return _term;
      }
      set
      {
        __isset.term = true;
        this._term = value;
      }
    }

    public long Last_log_id
    {
      get
      {
        return _last_log_id;
      }
      set
      {
        __isset.last_log_id = true;
        this._last_log_id = value;
      }
    }

    public long Last_log_term
    {
      get
      {
        return _last_log_term;
      }
      set
      {
        __isset.last_log_term = true;
        this._last_log_term = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool space;
      public bool part;
      public bool candidate_addr;
      public bool candidate_port;
      public bool term;
      public bool last_log_id;
      public bool last_log_term;
    }

    public AskForVoteRequest()
    {
    }

    public AskForVoteRequest DeepCopy()
    {
      var tmp0 = new AskForVoteRequest();
      if(__isset.space)
      {
        tmp0.Space = this.Space;
      }
      tmp0.__isset.space = this.__isset.space;
      if(__isset.part)
      {
        tmp0.Part = this.Part;
      }
      tmp0.__isset.part = this.__isset.part;
      if((Candidate_addr != null) && __isset.candidate_addr)
      {
        tmp0.Candidate_addr = this.Candidate_addr;
      }
      tmp0.__isset.candidate_addr = this.__isset.candidate_addr;
      if(__isset.candidate_port)
      {
        tmp0.Candidate_port = this.Candidate_port;
      }
      tmp0.__isset.candidate_port = this.__isset.candidate_port;
      if(__isset.term)
      {
        tmp0.Term = this.Term;
      }
      tmp0.__isset.term = this.__isset.term;
      if(__isset.last_log_id)
      {
        tmp0.Last_log_id = this.Last_log_id;
      }
      tmp0.__isset.last_log_id = this.__isset.last_log_id;
      if(__isset.last_log_term)
      {
        tmp0.Last_log_term = this.Last_log_term;
      }
      tmp0.__isset.last_log_term = this.__isset.last_log_term;
      return tmp0;
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
                Space = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I32)
              {
                Part = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.String)
              {
                Candidate_addr = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.I32)
              {
                Candidate_port = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.I64)
              {
                Term = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.I64)
              {
                Last_log_id = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.I64)
              {
                Last_log_term = await iprot.ReadI64Async(cancellationToken);
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
        var tmp1 = new TStruct("AskForVoteRequest");
        await oprot.WriteStructBeginAsync(tmp1, cancellationToken);
        var tmp2 = new TField();
        if(__isset.space)
        {
          tmp2.Name = "space";
          tmp2.Type = TType.I32;
          tmp2.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteI32Async(Space, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.part)
        {
          tmp2.Name = "part";
          tmp2.Type = TType.I32;
          tmp2.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteI32Async(Part, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Candidate_addr != null) && __isset.candidate_addr)
        {
          tmp2.Name = "candidate_addr";
          tmp2.Type = TType.String;
          tmp2.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteStringAsync(Candidate_addr, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.candidate_port)
        {
          tmp2.Name = "candidate_port";
          tmp2.Type = TType.I32;
          tmp2.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteI32Async(Candidate_port, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.term)
        {
          tmp2.Name = "term";
          tmp2.Type = TType.I64;
          tmp2.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteI64Async(Term, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.last_log_id)
        {
          tmp2.Name = "last_log_id";
          tmp2.Type = TType.I64;
          tmp2.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteI64Async(Last_log_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.last_log_term)
        {
          tmp2.Name = "last_log_term";
          tmp2.Type = TType.I64;
          tmp2.ID = 7;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteI64Async(Last_log_term, cancellationToken);
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
      if (!(that is AskForVoteRequest other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.space == other.__isset.space) && ((!__isset.space) || (System.Object.Equals(Space, other.Space))))
        && ((__isset.part == other.__isset.part) && ((!__isset.part) || (System.Object.Equals(Part, other.Part))))
        && ((__isset.candidate_addr == other.__isset.candidate_addr) && ((!__isset.candidate_addr) || (System.Object.Equals(Candidate_addr, other.Candidate_addr))))
        && ((__isset.candidate_port == other.__isset.candidate_port) && ((!__isset.candidate_port) || (System.Object.Equals(Candidate_port, other.Candidate_port))))
        && ((__isset.term == other.__isset.term) && ((!__isset.term) || (System.Object.Equals(Term, other.Term))))
        && ((__isset.last_log_id == other.__isset.last_log_id) && ((!__isset.last_log_id) || (System.Object.Equals(Last_log_id, other.Last_log_id))))
        && ((__isset.last_log_term == other.__isset.last_log_term) && ((!__isset.last_log_term) || (System.Object.Equals(Last_log_term, other.Last_log_term))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.space)
        {
          hashcode = (hashcode * 397) + Space.GetHashCode();
        }
        if(__isset.part)
        {
          hashcode = (hashcode * 397) + Part.GetHashCode();
        }
        if((Candidate_addr != null) && __isset.candidate_addr)
        {
          hashcode = (hashcode * 397) + Candidate_addr.GetHashCode();
        }
        if(__isset.candidate_port)
        {
          hashcode = (hashcode * 397) + Candidate_port.GetHashCode();
        }
        if(__isset.term)
        {
          hashcode = (hashcode * 397) + Term.GetHashCode();
        }
        if(__isset.last_log_id)
        {
          hashcode = (hashcode * 397) + Last_log_id.GetHashCode();
        }
        if(__isset.last_log_term)
        {
          hashcode = (hashcode * 397) + Last_log_term.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp3 = new StringBuilder("AskForVoteRequest(");
      int tmp4 = 0;
      if(__isset.space)
      {
        if(0 < tmp4++) { tmp3.Append(", "); }
        tmp3.Append("Space: ");
        Space.ToString(tmp3);
      }
      if(__isset.part)
      {
        if(0 < tmp4++) { tmp3.Append(", "); }
        tmp3.Append("Part: ");
        Part.ToString(tmp3);
      }
      if((Candidate_addr != null) && __isset.candidate_addr)
      {
        if(0 < tmp4++) { tmp3.Append(", "); }
        tmp3.Append("Candidate_addr: ");
        Candidate_addr.ToString(tmp3);
      }
      if(__isset.candidate_port)
      {
        if(0 < tmp4++) { tmp3.Append(", "); }
        tmp3.Append("Candidate_port: ");
        Candidate_port.ToString(tmp3);
      }
      if(__isset.term)
      {
        if(0 < tmp4++) { tmp3.Append(", "); }
        tmp3.Append("Term: ");
        Term.ToString(tmp3);
      }
      if(__isset.last_log_id)
      {
        if(0 < tmp4++) { tmp3.Append(", "); }
        tmp3.Append("Last_log_id: ");
        Last_log_id.ToString(tmp3);
      }
      if(__isset.last_log_term)
      {
        if(0 < tmp4++) { tmp3.Append(", "); }
        tmp3.Append("Last_log_term: ");
        Last_log_term.ToString(tmp3);
      }
      tmp3.Append(')');
      return tmp3.ToString();
    }
  }

}
