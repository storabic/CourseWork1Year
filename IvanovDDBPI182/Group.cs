using System.Collections.Generic;
using Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;

namespace IvanovDDBPI182
{
    public class Group : RangeOfShapes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Group"/> class.
        /// </summary>
        public Group():base()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Group"/> class.
        /// </summary>
        /// <param name="shapeRange">The shape range.</param>
        public Group(ShapeRange shapeRange) : base(shapeRange)
        {

        }
        /// <summary>
        /// Returns the types of all objects in group.
        /// </summary>
        /// <returns></returns>
        public string ReturnTypes()
        {
            // All types of PowerPoint shapes conveniently
            Dictionary<Office.MsoShapeType, string> MSOfficeTypes = new Dictionary<Office.MsoShapeType, string>()
            {
                {Office.MsoShapeType.msoAutoShape, "Фигура" },
                {Office.MsoShapeType.msoCallout,"Выделитель" },
                {Office.MsoShapeType.msoCanvas,"Холст" },
                {Office.MsoShapeType.msoChart,"График" },
                {Office.MsoShapeType.msoComment,"Комментарий" },
                {Office.MsoShapeType.msoDiagram,"Диаграмма" },
                {Office.MsoShapeType.msoEmbeddedOLEObject,"Встроенный OLE объект" },
                {Office.MsoShapeType.msoFormControl,"Контроллер формы" },
                {Office.MsoShapeType.msoFreeform,"Свободная форма" },
                {Office.MsoShapeType.msoGroup,"Группа(встроенная) объектов" },
                {Office.MsoShapeType.msoInk,"Чернила" },
                {Office.MsoShapeType.msoInkComment,"Комментарий к чернилам" },
                {Office.MsoShapeType.msoLine,"Линия" },
                {Office.MsoShapeType.msoLinkedOLEObject,"Связанный OLE объект" },
                {Office.MsoShapeType.msoLinkedPicture,"Связанная картинка" },
                {Office.MsoShapeType.msoMedia,"Медиаобъект" },
                {Office.MsoShapeType.msoOLEControlObject,"Контроллер OLE объекта" },
                {Office.MsoShapeType.msoPicture,"Рисунок" },
                {Office.MsoShapeType.msoPlaceholder,"Элемент \"Объект\"" },
                {Office.MsoShapeType.msoScriptAnchor,"Якорь скрипта" },
                {Office.MsoShapeType.msoShapeTypeMixed,"Объект смешанного типа" },
                {Office.MsoShapeType.msoTable,"Таблица" },
                {Office.MsoShapeType.msoTextBox,"Текст" },
                {Office.MsoShapeType.msoTextEffect,"Текстовый эффект" },
                {Office.MsoShapeType.msoWebVideo,"Веб-видео" },
            };
            HashSet<string> shapesTypes = new HashSet<string>();
            foreach (Shape shape in ShapesList)
            {
                shapesTypes.Add(MSOfficeTypes[shape.Type]);
            }
            string res = "";
            foreach (string type in shapesTypes)
            {
                res += type + "\n";
            }
            return res;
        }
    }
}