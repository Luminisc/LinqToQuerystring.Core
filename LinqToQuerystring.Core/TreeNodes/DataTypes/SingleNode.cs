namespace LinqToQuerystring.TreeNodes.DataTypes
{
    using Antlr.Runtime;
    using LinqToQuerystring.TreeNodes.Base;
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Linq.Expressions;

    public class SingleNode : TreeNode
    {
        public SingleNode(Type inputType, IToken payload, TreeNodeFactory treeNodeFactory)
            : base(inputType, payload, treeNodeFactory)
        {
        }

        public override Expression BuildLinqExpression(IQueryable query, Expression expression, Expression item = null)
        {
            return Expression.Constant(Convert.ToSingle(this.Text.Replace("f", string.Empty), CultureInfo.InvariantCulture));
        }
    }
}