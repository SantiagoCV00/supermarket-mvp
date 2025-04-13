using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface IPayModeView
    {
        string PayModelId { get; set; }
        string PayModelName { get; set; }
        string? SearchValue { get; set; }

        string GetPayModeObservation();
        void SetPayModeObservation(string value);
        string GetSearchValue();
        void SetSearchValue(string value);

        bool GetIsEdit();
        void SetIsEdit(bool value);

        bool GetIsSuccessful();
        void SetIsSuccessful(bool value);

        string GetMessage();
        void SetMessage(string value);

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetPayModelistBildingSource(BindingSource payModeList);
        void Show();
    }
}
