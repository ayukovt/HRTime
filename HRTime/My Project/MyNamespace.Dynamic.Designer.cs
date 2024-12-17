using System;
using System.ComponentModel;
using System.Diagnostics;

namespace HRTime.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {

            [EditorBrowsable(EditorBrowsableState.Never)]
            public alert m_alert;

            public alert alert
            {
                [DebuggerHidden]
                get
                {
                    m_alert = Create__Instance__(m_alert);
                    return m_alert;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_alert))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_alert);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public dashboard m_dashboard;

            public dashboard dashboard
            {
                [DebuggerHidden]
                get
                {
                    m_dashboard = Create__Instance__(m_dashboard);
                    return m_dashboard;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_dashboard))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_dashboard);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public firstsetup m_firstsetup;

            public firstsetup firstsetup
            {
                [DebuggerHidden]
                get
                {
                    m_firstsetup = Create__Instance__(m_firstsetup);
                    return m_firstsetup;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_firstsetup))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_firstsetup);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form1 m_Form1;

            public Form1 Form1
            {
                [DebuggerHidden]
                get
                {
                    m_Form1 = Create__Instance__(m_Form1);
                    return m_Form1;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form1))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form1);
                }
            }

        }


    }
}