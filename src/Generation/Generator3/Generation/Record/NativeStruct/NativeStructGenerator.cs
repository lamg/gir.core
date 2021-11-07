﻿namespace Generator3.Generation.Record
{
    public class NativeStructGenerator
    {
        private readonly Template<NativeStructModel> _template;
        private readonly Publisher _publisher;

        public NativeStructGenerator(Template<NativeStructModel> template, Publisher publisher)
        {
            _template = template;
            _publisher = publisher;
        }

        public void Generate(GirModel.Record record)
        {
            try
            {
                var model = new NativeStructModel(record);
                var source = _template.Render(model);
                var codeUnit = new CodeUnit(record.Namespace.GetCanonicalName(), $"{record.Name}.Struct", source);
                _publisher.Publish(codeUnit);
            }
            catch
            {
                Log.Warning($"Could not generate native struct for record \"{record.Name}\"");
                throw;
            }
        }
    }
}
